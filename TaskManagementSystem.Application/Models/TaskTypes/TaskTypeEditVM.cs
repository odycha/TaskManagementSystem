using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Application.Models.TaskTypes;

public class TaskTypeEditVM
{
    public int Id { get; set; }
    [Required]
    [Length(4, 150, ErrorMessage = "You have violated the length requirements")]
    public string Name { get; set; } = string.Empty;
    [Required]
    public DateOnly StartDate { get; set; }
    [Required]
    [Length(4, 150, ErrorMessage = "You have violated the length requirements")]
    public string Department { get; set; } = string.Empty;
	[Required]
	[Range(1, 10, ErrorMessage = "Skill level must be between 1 and 10.")]
	public int SkillLevel { get; set; }
	[MaxLength(200)]
    public string Description { get; set; } = string.Empty;

    //TODO: WHEN I EDIT A TASK IT BECOMES ALLOCATED AND ALL ALLOCATIONS GET DELETED

}
