﻿using System.Text.Json.Serialization;

namespace TaskManagementSystem.Application.Models.TaskAllocation;

public class TaskAllocationVM
{
	public int Id { get; set; }
	public WorkingDayReadOnlyVM WorkingDay { get; set; } = new WorkingDayReadOnlyVM();
	public TaskTypeReadOnlyVM TaskType { get; set; } = new TaskTypeReadOnlyVM();

	[JsonIgnore]
	public EmployeeAllocationVM Employee { get; set; } = new EmployeeAllocationVM();

}
