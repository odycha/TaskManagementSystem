


namespace TaskManagementSystem.Application.Services.TaskAllocations;

public interface ITaskAllocationsService
{
	Task AllocateTask(int taskId);
	Task<EmployeeAllocationVM> GetAllocations(string? userId);
	Task<List<UnallocatedTaskVM>> GetAllUnallocatedTasks();
	Task<List<TaskAllocationVM>> GetEmployeeAllocations();
	Task<List<EmployeeListVM>> GetEmployees();
	Task<UnallocatedTaskVM> GetUnallocatedTask(int taskId);
}
