using TaskManagementSystem.Application.Models.TaskTypes;


namespace TaskManagementSystem.Application.Services.TaskTypes;

public interface ITaskTypesService
{
    Task<List<TaskTypeReadOnlyVM>> GetAll(DateOnly? fromDate, DateOnly? toDate, TimeOnly? fromTime, TimeOnly? toTime, string? department, int? skillLevel, bool? allocated, bool? isCompleted);
    Task Create(TaskTypeCreateVM model);
    Task<T?> Get<T>(int id) where T : class;
    Task<bool> Remove(int id);
	Task<bool> Edit(TaskTypeEditVM model);
	Task<TaskTypeReadOnlyVM> Get(int id);
}
