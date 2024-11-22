
namespace TaskManagementSystem.Application.Services.TaskAllocations;

public interface ITaskAllocationsService
{
	Task AllocateTask(int taskId);
	Task<EmployeeAllocationVM> GetAllocations(string? userId);
	Task<List<TaskAllocationVM>> GetEmployeeAllocations();
	Task<List<EmployeeListVM>> GetEmployees(string? department, int? minimumSkillLevel);
	Task<TaskTypeReadOnlyVM> GetUnallocatedTask(int taskId);
}
