namespace TaskManagementSystem.Application.Models.WorkingDays;

public class WorkingDayReadOnlyVM : WorkingDayCreateVM
{
	public string DayFormatted => Day.ToString("yyyy-MM-dd");
}
