namespace TaskManagementSystem.Data;

public class ApplicationUser : IdentityUser
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public DateOnly DateOfBirth { get; set; }
	public string DepartmentName { get; set; }
	public int SkillLevel { get; set; }
	public List<TaskAllocation>? TaskAllocations { get; set; }

}
