using TaskManagementSystem.Application.Models.TaskTypes;


namespace TaskManagementSystem.Application.Services.TaskTypes;

public interface ITaskTypesService
{
    Task<List<TaskTypeReadOnlyVM>> GetAll(DateOnly? fromDate, DateOnly? toDate, string? department, int? skillLevel, bool? allocated);
    Task Create(TaskTypeCreateVM model);
    Task<T?> Get<T>(int id) where T : class;
    Task Remove(int id);
	Task Edit(TaskTypeEditVM model);
	Task<TaskTypeReadOnlyVM> Get(int id);
}
