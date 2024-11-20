using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagementSystem.Application.Services.TaskAllocations;

public class TaskAllocationsService(
    ApplicationDbContext _context, 
    IHttpContextAccessor _httpContextAccessor,
    UserManager<ApplicationUser> _userManager, 
    IMapper _mapper, IUserService _userService) : ITaskAllocationsService
{
    //TODO
    public async Task AllocateTask( int taskId)
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
			throw new InvalidOperationException("Working day not found");
		}

		//get employee with no other allocation for the certain working day and the minimum skill
		var employee = await _context.Users
		    .Where(e => !e.TaskAllocations.Any(ta => ta.WorkingDayId == workingDay.Id) // No other allocations on that day (1 to many relationship)
					    && e.SkillLevel >= task.SkillLevel
                        && e.DepartmentName == task.Department) // Assuming 'SkillLevel' exists on User
		    .OrderBy(e => e.SkillLevel) // Optionally, order by skill level to get the lower-skilled employee first
		    .FirstOrDefaultAsync();
		if (employee == null)
		{
			// Handle case where no suitable employee is found
			throw new InvalidOperationException("No available employee found for the task");
		}
		var taskAllocation = new TaskAllocation
        {
            TaskTypeId = task.Id,
            EmployeeId = employee.Id,
            WorkingDayId = workingDay.Id
        };
        //change the task allocation to true - allocated
        task.Allocated = true;
        _context.Add(taskAllocation);
        await _context.SaveChangesAsync();
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



	//GET 
	public async Task<List<UnallocatedTaskVM>> GetAllUnallocatedTasks()
    {
        var data = await _context.TaskTypes
            .Where(q => q.Allocated == false)
            .ToListAsync();
        var model = _mapper.Map<List<UnallocatedTaskVM>>(data);
        return model;
    }



    public async Task<UnallocatedTaskVM> GetUnallocatedTask(int taskId)
    {
        var data = await _context.TaskTypes
            .Where(q => q.Id == taskId)
            .SingleOrDefaultAsync();
        var model = _mapper.Map<UnallocatedTaskVM>(data);
        return model;
    }

    public async Task<List<EmployeeListVM>> GetEmployees()
    {
        var users = await _userService.GetEmployees();
		//explicitly states that the mapping is converting from a List<ApplicationUser> to a List<EmployeeListVM>
		var employees = _mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(users);
        employees = employees
            .OrderBy(e => e.DepartmentName)
            .ThenByDescending(e => e.SkillLevel)
            .ToList();
        return employees;
	}
}


//why is employees an IEnumerable it was a List? Even though employees starts as a List<EmployeeListVM>,
//when you apply LINQ methods like OrderBy or ThenBy, the result is not a List but an IEnumerable<EmployeeListVM>.






//2. Explicit Mapping with Source and Destination Types
//_mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(users):
//This is used when you want to be explicit about both the source and destination types, even if AutoMapper can infer them.
//This approach is more verbose but ensures clarity, especially if there’s any ambiguity in your mapping configuration or if users could be a polymorphic list.