using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Application.Models.TaskAllocation;

public class EmployeeListVM
{
	public string Id { get; set; } = string.Empty;

	[Display(Name = "First Name")]
	public string FirstName { get; set; } = string.Empty;

	[Display(Name = "Last Name")]
	public string LastName { get; set; } = string.Empty;

    [Display(Name = "Date of Birth")]
    public DateOnly DateOfBirth { get; set; }
	public string DateOfBirthFormatted => DateOfBirth.ToString("dd-MM-yyyy");

    [Display(Name = "Department Name")]
    public string DepartmentName { get; set; } = string.Empty;

    [Display(Name = "Skill Level")]
    public int SkillLevel { get; set; }

	[Display(Name = "Email Address")]
	public string Email { get; set; } = string.Empty;
}
