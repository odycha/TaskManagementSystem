namespace TaskManagementSystem.Application.Models.TaskAllocation;

public class EmployeeAllocationVM : EmployeeListVM
{
	public List<TaskAllocationVM> TaskAllocations { get; set; } = new List<TaskAllocationVM>();

}




