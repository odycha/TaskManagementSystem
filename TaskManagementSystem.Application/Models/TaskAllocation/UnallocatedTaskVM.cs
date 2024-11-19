using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Application.Models.TaskAllocation;

public class UnallocatedTaskVM
{
    public int Id { get; set; }
    [DisplayName("Task")]
    public string Name { get; set; } = string.Empty;
    [DisplayName("Start Date")]
    public DateOnly StartDate { get; set; }
    [DisplayName("Department")]
    public string Department { get; set; } = string.Empty;
    [DisplayName("Skill level")]
    public int SkillLevel { get; set; }

    [DisplayName("Description")]
    public string Description { get; set; } = string.Empty;

    [DisplayName("Task Allocation")]
    public bool Allocated { get; set; }

}
