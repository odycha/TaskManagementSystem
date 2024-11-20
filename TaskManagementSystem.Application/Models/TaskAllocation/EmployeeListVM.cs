using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Application.Models.TaskAllocation;

public class EmployeeListVM
{
	//Avoiding Null Reference Issues (Empty)
	public string Id { get; set; } = string.Empty;

	[Display(Name = "First Name")]
	public string FirstName { get; set; } = string.Empty;

	[Display(Name = "Last Name")]
	public string LastName { get; set; } = string.Empty;
	public DateOnly DateOfBirth { get; set; }
	public string DepartmentName { get; set; } = string.Empty;
	public int SkillLevel { get; set; }

	[Display(Name = "Email Address")]
	public string Email { get; set; } = string.Empty;
}
