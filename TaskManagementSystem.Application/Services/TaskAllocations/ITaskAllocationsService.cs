
namespace TaskManagementSystem.Application.Services.TaskAllocations;

public interface ITaskAllocationsService
{
	Task<bool> AllocateTask(int taskId);
	Task<bool> Complete(int id);
	Task<TaskAllocationVM> GetAllocation(int allocationId);
	Task<EmployeeAllocationVM> GetAllocations(string? userId, DateOnly? fromDate, DateOnly? toDate, TimeOnly? fromTime,
		TimeOnly? toTime, int? minimumSkillLevel, bool? isCompleted);
	Task<EmployeeEmailVM> GetEmployee(string id);
	Task<List<TaskAllocationVM>> GetEmployeeAllocations();
	Task<List<EmployeeListVM>> GetEmployees(string? department, int? minimumSkillLevel);
	Task<bool> Remove(int allocationId);
	Task<bool> SendEmail(EmployeeEmailVM model);
}
