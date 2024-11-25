namespace TaskManagementSystem.Application.Services.WorkingDays;

public interface IWorkingDaysService
{
    Task<List<WorkingDayReadOnlyVM>> GetAll();
    Task Create(WorkingDayCreateVM model);
	Task<T?> Get<T>(int id) where T : class;
	Task Remove(int id);
	Task Edit(WorkingDayCreateVM model);
}
