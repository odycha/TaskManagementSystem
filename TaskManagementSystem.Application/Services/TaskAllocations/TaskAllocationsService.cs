using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace TaskManagementSystem.Application.Services.TaskAllocations;

public class TaskAllocationsService(ApplicationDbContext _context, IHttpContextAccessor _httpContextAccessor,
    UserManager<ApplicationUser> _userManager, IMapper _mapper) : ITaskAllocationsService
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


    //TODO
    public async Task<List<TaskAllocation>> GetAllocations()
    {
        var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
        var taskAllocations = await _context.TaskAllocations
            .Include(q => q.TaskType)
            .Include(q => q.WorkingDay)
            .Where(q => q.EmployeeId == user.Id)
            .ToListAsync();
        return taskAllocations;
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







}
