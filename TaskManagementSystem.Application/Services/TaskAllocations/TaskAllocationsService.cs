﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace TaskManagementSystem.Application.Services.TaskAllocations;

public class TaskAllocationsService(
	ApplicationDbContext _context,
	IHttpContextAccessor _httpContextAccessor,
	UserManager<ApplicationUser> _userManager,
	IMapper _mapper, IUserService _userService,
	IEmailSender _emailSender,
	IWebHostEnvironment _hostEnvironment) : ITaskAllocationsService
{
	public async Task<bool> AllocateTask(int taskId)
	{
		//SingleAsync if it finds more than 1 throws exception
		bool employeeNotified = false;
		var task = await _context.TaskTypes.SingleOrDefaultAsync(x => x.Id == taskId);
		if (task == null || task.Completed == true)
		{
			// Handle case where the task is not found
			throw new InvalidOperationException("Task not found");
		}
		var workingDay = await _context.WorkingDays.SingleOrDefaultAsync(x => x.Day == task.StartDate);
		if (workingDay == null)

		{
			// Handle case where the working day is not found
			throw new WorkingDayNotFoundException(task.StartDate);
		}
		if (task.StartTime < workingDay.StartTime || task.EndTime > workingDay.EndTime)
		{
			throw new InvalidTimeInputException("Task cant be allocated outside the working period");
		}

		//get employee with no other allocation for the certain working day and the minimum skill
		var employee = await _context.Users
			// No other allocations on that day and time period - all true in order to reject
			.Where(e => !e.TaskAllocations.Any(ta =>
				ta.WorkingDayId == workingDay.Id &&
				ta.TaskType.StartTime < task.EndTime &&
				ta.TaskType.EndTime > task.StartTime)

				&& e.SkillLevel >= task.SkillLevel
				&& e.DepartmentName == task.Department) // Assuming 'SkillLevel' exists on User
			.OrderBy(e => e.SkillLevel) // Optionally, order by skill level to get the lower-skilled employee first
			.FirstOrDefaultAsync();
		if (employee == null)
		{
			// Handle case where no suitable employee is found
			throw new NoSuitableEmployeeException($"{task.Name}");
		}
		var taskAllocation = new TaskAllocation
		{
			TaskTypeId = task.Id,
			EmployeeId = employee.Id,
			WorkingDayId = workingDay.Id
		};
		//change the task allocation to true - allocated
		task.Allocated = true;
		//Send email to inform employee about the task
		_context.Add(taskAllocation);
		await _context.SaveChangesAsync();

		// grab the Email template
		var emailTemplatePath = Path.Combine(_hostEnvironment.WebRootPath, "templates", "email_layout.html");
		var template = await System.IO.File.ReadAllTextAsync(emailTemplatePath);
		var messageBody = template
			.Replace("{UserName}", $"{employee.FirstName} {employee.LastName}")
			.Replace("{MessageContent}",
			$"A new Task has been allocated to you! Task name: {task.Name} date: {task.StartDate}. See more details at your page.");
		try
		{
			await _emailSender.SendEmailAsync(employee.Email, "Task Allocation", messageBody);
		}
		catch (Exception e)
		{
			return employeeNotified;
		}
		return employeeNotified = true;
	}

	public async Task<bool> Complete(int id)
	{
		bool taskManagerNotified = false;
		var data = await _context.TaskTypes
			.Where(t => t.Id == id)
			.Include(t => t.TaskAllocation.Employee)
			.SingleAsync();
		data.Completed = true;
		_context.Update(data);
		await _context.SaveChangesAsync();

		// grab the Email template
		var emailTemplatePath = Path.Combine(_hostEnvironment.WebRootPath, "templates", "email_layout.html");
		var template = await System.IO.File.ReadAllTextAsync(emailTemplatePath);
		var messageBody = template
			.Replace("{UserName}", $"Task Manager")
			.Replace("{MessageContent}",
			$"The task {data.Name} (date: {data.StartDate}) has been completed by the employee: {data.TaskAllocation.Employee.FirstName} {data.TaskAllocation.Employee.LastName}.");
		try
		{
			await _emailSender.SendEmailAsync("taskManager@localhost.com", "Task Completion", messageBody);
		}
		catch (Exception e)
		{
			return taskManagerNotified;
		}
		return taskManagerNotified = true;
	}

	public async Task<List<TaskAllocationVM>> GetEmployeeAllocations()
	{
		var user = await _userService.GetLoggedInUser();
		var data = await _context.TaskAllocations
			.Include(d => d.TaskType)
			.Include(d => d.WorkingDay)
			.Where(e => e.EmployeeId == user.Id)
			.ToListAsync();
		var viewData = _mapper.Map<List<TaskAllocationVM>>(data);
		return viewData;
	}



	//Get allocations for a specific employee
	//The reason you can't directly access taskAllocations.Employee in your method is because taskAllocations is a collection (a List<TaskAllocation>), not a single instance of TaskAllocation
	public async Task<EmployeeAllocationVM> GetAllocations(string? userId, DateOnly? fromDate, DateOnly? toDate, TimeOnly? fromTime,
		TimeOnly? toTime, int? minimumSkillLevel, bool? isCompleted)
	{
		//if (string.IsNullOrEmpty(userId))
		//	throw new ArgumentException("User ID cannot be null or empty.", nameof(userId));

		var employee = await _userService.GetUserById(userId);

		// Fetch task allocations for the given employee ID
		var query = _context.TaskAllocations
	.Include(q => q.TaskType)
	.Include(q => q.WorkingDay)
	.Where(q => q.EmployeeId == userId);

		// Date Filtering
		if (fromDate.HasValue)
		{
			query = query.Where(t => t.TaskType.StartDate >= fromDate.Value);
		}
		if (toDate.HasValue)
		{
			query = query.Where(t => t.TaskType.StartDate <= toDate.Value);
		}

		// Time Filtering
		if (fromTime.HasValue)
		{
			query = query.Where(t => t.TaskType.StartTime >= fromTime.Value);
		}
		if (toTime.HasValue)
		{
			query = query.Where(t => t.TaskType.EndTime <= toTime.Value);
		}

		// Skill Level Filtering
		if (minimumSkillLevel.HasValue)
		{
			query = query.Where(t => t.TaskType.SkillLevel >= minimumSkillLevel.Value);
		}

		// Completion Status Filtering
		if (isCompleted.HasValue)
		{
			query = query.Where(t => t.TaskType.Completed == isCompleted.Value);
		}

		// Execute Query
		var taskAllocations = await query.ToListAsync();

		// Map task allocations to TaskAllocationVM
		var allocationVmList = _mapper.Map<List<TaskAllocation>, List<TaskAllocationVM>>(taskAllocations);

		// Map employee and allocations to EmployeeAllocationVM
		var employeeAllocationVm = new EmployeeAllocationVM
		{
			Id = employee.Id,
			FirstName = employee.FirstName,
			LastName = employee.LastName,
			Email = employee.Email,
			DateOfBirth = employee.DateOfBirth,
			DepartmentName = employee.DepartmentName,
			SkillLevel = employee.SkillLevel,
			TaskAllocations = allocationVmList
		};

		return employeeAllocationVm;
	}

	public async Task<TaskAllocationVM> GetAllocation(int allocationId)
	{
		var data = await _context.TaskAllocations
			.Where(a => a.Id == allocationId)
			.Include(a => a.TaskType)
			.Include(a => a.Employee)
			.SingleOrDefaultAsync();

		var viewData = _mapper.Map<TaskAllocationVM>(data);
		return viewData;
	}

	public async Task<EmployeeEmailVM> GetEmployee(string? id)
	{
		var fromUser = await _userService.GetLoggedInUser();
		if (id == null)
		{
			var employeeEmailVm = new EmployeeEmailVM
			{
				ToEmail = "example@localhost.com",
				Subject = string.Empty,
				Message = string.Empty,
				FromEmail = fromUser.Email
			};
			return employeeEmailVm;
		}
		else
		{
			var employee = await _userService.GetUserById(id);
			var employeeEmailVm = new EmployeeEmailVM
			{
				ToEmail = employee.Email,
				Id = employee.Id,
				Subject = string.Empty,
				Message = string.Empty,
				FromEmail = fromUser.Email
			};
			return employeeEmailVm;
		}
	}

	public async Task<bool> SendEmail(EmployeeEmailVM model)
	{
		bool emailSent = false;
		var configuration = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json")
			.Build();
		var emailSender = new EmailSender(configuration);
		try
		{
			await emailSender.SendEmailWithCustomFromAsync(model.ToEmail, model.Subject, model.Message, model.FromEmail);
		}
		catch (Exception e)
		{
			return emailSent;
		}
		return emailSent = true;
	}

	public async Task<List<EmployeeListVM>> GetEmployees(string? department, int? minimumSkillLevel)
	{
		var employees = await _userService.GetEmployees();
		//filter by department
		if (!string.IsNullOrEmpty(department))
		{
			employees = employees
				.Where(e => e.DepartmentName == department)
				.ToList();
		}
		//filter by minimum skill level
		if (minimumSkillLevel.HasValue)
		{
			employees = employees
				.Where(e => e.SkillLevel >= minimumSkillLevel)
				.ToList();
		}
		//explicitly states that the mapping is converting from a List<ApplicationUser> to a List<EmployeeListVM>
		var employeesVm = _mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(employees);
		employeesVm = employeesVm
			.OrderBy(e => e.DepartmentName)
			.ThenByDescending(e => e.SkillLevel)
			.ToList();
		return employeesVm;
	}

	public async Task<bool> Remove(int allocationId)
	{
		bool employeeNotified = false;
		var data = await _context.TaskAllocations
			.Where(a => a.Id == allocationId)
			.Include(a => a.TaskType)
			.Include(a => a.Employee)
			.SingleOrDefaultAsync();

		if (data != null)
		{
			//inform employee about deallocation
			var emailTemplatePath = Path.Combine(_hostEnvironment.WebRootPath, "templates", "email_layout.html");
			var template = await System.IO.File.ReadAllTextAsync(emailTemplatePath);
			var messageBody = template
				.Replace("{UserName}", $"{data.Employee.FirstName} {data.Employee.LastName}")
			.Replace("{MessageContent}",
				$"You have been deallocated from the task: {data.TaskType.Name} - date: {data.TaskType.StartDate}");

			data.TaskType.Allocated = false;
			_context.Remove(data);
			await _context.SaveChangesAsync();
			try
			{
				await _emailSender.SendEmailAsync(data.Employee.Email, "Task Deallocation", messageBody);
			}
			catch (Exception e)
			{
				return employeeNotified;
			}
		}
		else
		{
			throw new FileNotFoundException();
		}
		return employeeNotified = true;
	}
}


// Explicit Mapping with Source and Destination Types
//_mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(users):
//This is used when you want to be explicit about both the source and destination types, even if AutoMapper can infer them.
//This approach is more verbose but ensures clarity, especially if there’s any ambiguity in your mapping configuration or if users could be a polymorphic list.