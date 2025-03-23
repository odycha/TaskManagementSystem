using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TaskManagementSystem.Application.Models.WorkingDays;

public class WorkingDayCreateVM
{
	public int Id { get; set; }
	[Required]
    [DisplayName("Working Day")]
    public DateOnly Day { get; set; }
    [Required]
    [DisplayName("Start Time")]
    public TimeOnly StartTime { get; set; }
    [Required]
    [DisplayName("End Time")]
    public TimeOnly EndTime { get; set; }
    [MaxLength(200)]
    public string Comments { get; set; } = string.Empty;

}
 