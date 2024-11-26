
namespace TaskManagementSystem.Application.Services.TaskAllocations;

public interface ITaskAllocationsService
{
	Task AllocateTask(int taskId);
	Task<TaskAllocationVM> GetAllocation(int allocationId);
	Task<EmployeeAllocationVM> GetAllocations(string? userId);
	Task<EmployeeEmailVM> GetEmployee(string id);
	Task<List<TaskAllocationVM>> GetEmployeeAllocations();
	Task<List<EmployeeListVM>> GetEmployees(string? department, int? minimumSkillLevel);
	Task<TaskTypeReadOnlyVM> GetUnallocatedTask(int taskId);
	Task Remove(int allocationId);
	Task SendEmail(EmployeeEmailVM model);
}
