﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Application.Models.TaskTypes;

public class TaskTypeReadOnlyVM
{
    public int Id { get; set; }
	[DisplayName("Task")]
	public string Name { get; set; } = string.Empty;
	[DisplayName("Start Date")]
	public DateOnly StartDate { get; set; }
	public string StartDateFormatted => StartDate.ToString("dd-MM-yyyy");

    [DisplayName("Start Time")]
    public TimeOnly StartTime { get; set; }

    [DisplayName("End Time")]
    public TimeOnly EndTime { get; set; }

    [DisplayName("Department")]
	public string Department { get; set; } = string.Empty;
    [DisplayName("Skill level")]
    public int SkillLevel { get; set; }

    [DisplayName("Description")]
	public string Description { get; set; } = string.Empty;

    [DisplayName("Task Condition")]
    public bool Allocated { get; set; }
    public bool Completed { get; set; }

    public int? TaskAllocationId { get; set; }

	//Use this when you want to ensure the property is always ready to use and avoid null reference exceptions.
	public EmployeeListVM employeeListVm { get; set; } = new EmployeeListVM();

}
