using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TaskManagementSystem.Application.Models.WorkingDays;

public class WorkingDayCreateVM
{
    [Required]
    [DisplayName("Working Day")]
    public DateOnly Day { get; set; }
    [MaxLength(200)]
    public string Comments { get; set; } = string.Empty;

}
