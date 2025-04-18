﻿using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Application.Models.TaskAllocation;

public class EmployeeEmailVM : EmployeeListVM
{
	[Required(ErrorMessage = "Email is required")]
	[EmailAddress(ErrorMessage = "Invalid email address format")]
	[Display(Name = "To Email")]
	public string ToEmail { get; set; }
    public string? FromEmail { get; set; } 

    [Required]
	[StringLength(60, MinimumLength = 2, ErrorMessage = "Subject must be between 2 and 60 characters")]
	public string Subject { get; set; }

	[Required]
	[StringLength(400, MinimumLength = 2, ErrorMessage = "Message must be between 2 and 400 characters")]
	public string Message { get; set; }

}
