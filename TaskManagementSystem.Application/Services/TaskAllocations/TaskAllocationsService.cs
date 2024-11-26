using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using TaskManagementSystem.Application.Models.TaskAllocation;

namespace TaskManagementSystem.Application.Services.TaskAllocations;

public class TaskAllocationsService(
    ApplicationDbContext _context,
    IHttpContextAccessor _httpContextAccessor,
    UserManager<ApplicationUser> _userManager,
    IMapper _mapper, IUserService _userService,
    IEmailSender _emailSender) : ITaskAllocationsService
    
{
    //TODO
    public async Task AllocateTask(int taskId)
    {
        //SingleAsync if it finds more than 1 throws exception
        var task = await _context.TaskTypes.SingleOrDefaultAsync(x => x.Id == taskId);
        if (task == null)
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
        await _emailSender.SendEmailAsync(employee.Email, "Task Allocation", $"A new Task has been allocated to you! Task name: {task.Name} date: {task.StartDate}. " +
            $"See more details at your page.");
        _context.Add(taskAllocation);
        await _context.SaveChangesAsync();
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
    public async Task<EmployeeAllocationVM> GetAllocations(string? userId)
    {
        //if (string.IsNullOrEmpty(userId))
        //	throw new ArgumentException("User ID cannot be null or empty.", nameof(userId));

        var employee = await _userService.GetUserById(userId);

        // Fetch task allocations for the given employee ID
        var taskAllocations = await _context.TaskAllocations
            .Include(q => q.TaskType)
            .Include(q => q.WorkingDay)
            .Where(q => q.EmployeeId == userId)
            .ToListAsync();


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

    public async Task<TaskTypeReadOnlyVM> GetUnallocatedTask(int taskId)
    {
        var data = await _context.TaskTypes
            .Where(q => q.Id == taskId)
            .SingleOrDefaultAsync();
        var model = _mapper.Map<TaskTypeReadOnlyVM>(data);
        return model;
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

	public async Task SendEmail(EmployeeEmailVM model)
	{
		var configuration = new ConfigurationBuilder()
	        .AddJsonFile("appsettings.json")
	        .Build();
		var emailSender = new EmailSender(configuration);
		await emailSender.SendEmailWithCustomFromAsync(model.Email, model.Subject, model.Message, model.FromEmail);
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
        if(minimumSkillLevel.HasValue)
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

    public async Task Remove(int allocationId)
    {
        var data = await _context.TaskAllocations
            .Where(a => a.Id == allocationId)
			.Include(a => a.TaskType)
			.Include(a => a.Employee)
            .SingleOrDefaultAsync();

        if(data != null)
        {
            //inform employee about deallocation
            await _emailSender.SendEmailAsync(data.Employee.Email, "Task Deallocation", $"You have been deallocated from the task: {data.TaskType.Name} - date: {data.TaskType.StartDate}");
            data.TaskType.Allocated = false;
			_context.Remove(data);
			await _context.SaveChangesAsync();
		}
        
    }
}



//TODO: When we edit a task the allocation must be deleted
//TODO: Add option in the tasks menu to unallocate it


//When a task is deleted, its related allocations are also deleted due to cascading behavior in your database setup.This behavior can occur through one of the following mechanisms, depending on how your data model and database are configured.




//why is employees an IEnumerable it was a List? Even though employees starts as a List<EmployeeListVM>,
//when you apply LINQ methods like OrderBy or ThenBy, the result is not a List but an IEnumerable<EmployeeListVM>.






//2. Explicit Mapping with Source and Destination Types
//_mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(users):
//This is used when you want to be explicit about both the source and destination types, even if AutoMapper can infer them.
//This approach is more verbose but ensures clarity, especially if there’s any ambiguity in your mapping configuration or if users could be a polymorphic list.