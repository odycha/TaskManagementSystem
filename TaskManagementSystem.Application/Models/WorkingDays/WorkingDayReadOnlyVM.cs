using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Application.Models.WorkingDays;

public class WorkingDayReadOnlyVM
{
    public int Id { get; set; }
    [DisplayName("Working Day")]
    public DateOnly Day { get; set; }
	public string DayFormatted => Day.ToString("yyyy-MM-dd");

    [DisplayName("Start Time")]
    public TimeOnly StartTime { get; set; }

    [DisplayName("End Time")]
    public TimeOnly EndTime { get; set; }
    public string Comments { get; set; } = string.Empty;
}
