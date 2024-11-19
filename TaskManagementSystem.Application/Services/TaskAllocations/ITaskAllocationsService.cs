


namespace TaskManagementSystem.Application.Services.TaskAllocations;

public interface ITaskAllocationsService
{
	Task AllocateTask(int taskId);
	Task<List<TaskAllocation>> GetAllocations();
    Task<List<UnallocatedTaskVM>> GetAllUnallocatedTasks();
    Task<UnallocatedTaskVM> GetUnallocatedTask(int taskId);
}
