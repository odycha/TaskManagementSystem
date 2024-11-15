using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Application.Models.TaskTypes;

public class TaskTypeCreateVM
{
    //Id not necessary it is created in the data model
    [Required]
    [Length(4, 150, ErrorMessage = "You have violated the length requirements")]
    public string Name { get; set; } = string.Empty;
    [Required]
    public DateOnly StartDate { get; set; }
    [Required]
    public DateOnly EndDate { get; set; }
    [Required]
    [Length(2, 150, ErrorMessage = "You have violated the length requirements")]
    public string Department { get; set; } = string.Empty;
    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;

}
