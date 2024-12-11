using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.WebUtilities;
using TaskManagementSystem.Application.Services.TaskAllocations;
using TaskManagementSystem.Common.Static;

namespace TaskManagementSystem.Web.Controllers;

[Authorize]
public class TaskAllocationController(ITaskAllocationsService _taskAllocationService) : Controller
{
	//Post
	[HttpPost]
	[AutoValidateAntiforgeryToken]
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> AllocateTask(int? id)
	{
        if (id == null)
        {
            return NotFound();
        }
        bool employeeNotified = false;
        try
		{
			employeeNotified = await _taskAllocationService.AllocateTask(id.Value);
		}
		catch (WorkingDayNotFoundException e)
		{
			return RedirectToAction("Create", "WorkingDays", new { comingFromAllocation = true, workingDayDate = e.MissingDate });
		}
		catch (InvalidTimeInputException e)
		{
			return RedirectToAction("Index", "TaskTypes", new { comingFromAllocation = true, taskOutOfWorkingPeriod = true });
		}
		catch (NoSuitableEmployeeException e)
		{
			return RedirectToAction("Index", "TaskTypes", new { noSuitableEmployee = true, taskName = e.Message });
		}
		catch (InvalidOperationException e)
		{
			return NotFound();
		}
	
		// Assuming 'refererUrl' is the previous URL you are redirecting to
		string refererUrl = Request.Headers["Referer"].ToString();

		// Append the 'employeeNotified' query parameter to the referer URL
		if (!string.IsNullOrEmpty(refererUrl))
		{
			refererUrl = QueryHelpers.AddQueryString(refererUrl, "employeeNotified", employeeNotified.ToString());
			return Redirect(refererUrl);
		}
		// Fallback if referer is unavailable
		return RedirectToAction("Index", "TaskTypes", new { employeeNotified });
	}

	[Authorize]
	public async Task<IActionResult> CompleteTask(int id)
	{
		bool taskManagerNotified = await _taskAllocationService.Complete(id);

		// Assuming 'refererUrl' is the previous URL you are redirecting to
		string refererUrl = Request.Headers["Referer"].ToString();

		// Append the 'employeeNotified' query parameter to the referer URL
		if (!string.IsNullOrEmpty(refererUrl))
		{
			refererUrl = QueryHelpers.AddQueryString(refererUrl, "employeeNotified", taskManagerNotified.ToString());
			return Redirect(refererUrl);
		}
		// Fallback if referer is unavailable
		return RedirectToAction("Index", "TaskTypes", new { taskManagerNotified });
	}

	//View All Employees
	[Authorize]
	public async Task<IActionResult> ViewEmployees(string? department, int? minimumSkillLevel)
	{
		var employees = await _taskAllocationService.GetEmployees(department, minimumSkillLevel);
		ViewBag.department = department;
		ViewBag.minimumSkillLevel = minimumSkillLevel;
		return View(employees);
	}

    [Authorize(Roles = $"{Roles.Employee}")]
    public async Task<IActionResult> ViewSignedInEmployeeAllocations(bool? taskManagerNotified)
	{
		var allocations = await _taskAllocationService.GetEmployeeAllocations();
		ViewBag.taskManagerNotified = taskManagerNotified;
		return View(allocations);
	}

	//View allocations for a specific employee
	[Authorize]
	//!!!!!!!!!!!!!!!!!!!!!!!!!!!!SOSOSOSOSOSOSOSOSOSO!!!! THE ID IN THE VIEW MUST HAVE THE SAME NAME WITH THE ACTION
	public async Task<IActionResult> ViewEmployeeAllocations(string? id, DateOnly? fromDate, 
		DateOnly? toDate, TimeOnly? fromTime,TimeOnly? toTime, int? minimumSkillLevel, bool? isCompleted)
	{
		if (id == null)
		{
			return NotFound();
		}
		var allocations = await _taskAllocationService.GetAllocations(id, fromDate, toDate, fromTime, toTime, minimumSkillLevel, isCompleted);
		ViewBag.fromDate = fromDate;
		ViewBag.toDate = toDate;
		ViewBag.toTime = toTime;
		ViewBag.fromTime = fromTime;
		ViewBag.minimumSkillLevel = minimumSkillLevel;
		ViewBag.isCompleted = isCompleted;
		return View(allocations);
	}


	//get
	[Authorize]
	public async Task<IActionResult> SendMailToEmployee(string? id, string? taskName)
	{
		var employeeVm = await _taskAllocationService.GetEmployee(id);
		ViewBag.taskName = taskName;
		return View(employeeVm);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	[Authorize]
	public async Task<IActionResult> SendMailToEmployee(EmployeeEmailVM model)
	{
		bool emailSent = await _taskAllocationService.SendEmail(model);
		if(emailSent == true)
		{
            var referer = Request.Headers.Referer.ToString();
            // Check if the "Referer" header exists
            if (!string.IsNullOrEmpty(referer))
            {
                // Redirect back to the previous page
                return Redirect(referer);
            }

            // Fallback if the referer is not available
            return RedirectToAction("Index", "TaskTypes");
        }
		else
		{
			ViewBag.emailSent = false;
            return View(model);
        }
	}

	//post
	[HttpPost, ActionName("Deallocate")]
	[ValidateAntiForgeryToken]
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> DeallocateConfirmed(int? id)
	{
		bool employeeNotified = false;
		if (id == null)
		{
			return NotFound();
		}
		try
		{
			employeeNotified = await _taskAllocationService.Remove(id.Value);
		}
		catch(Exception e)
		{
			return NotFound();
		}
		// Assuming 'refererUrl' is the previous URL you are redirecting to
		string refererUrl = Request.Headers["Referer"].ToString();

		// Append the 'employeeNotified' query parameter to the referer URL
		if (!string.IsNullOrEmpty(refererUrl))
		{
			refererUrl = QueryHelpers.AddQueryString(refererUrl, "employeeNotified", employeeNotified.ToString());
			return Redirect(refererUrl);
		}
		// Fallback if referer is unavailable
		return RedirectToAction("Index", "TaskTypes", new { employeeNotified });
	}
}





//TODO: Unallocate task AT TASKS PAGE

//TODO: WHEN LOOKING AT AN EMPLOYEE EXCEPT FROM VIEWING ALLOCATIONS - SEE ALSO A CALENDAR WITH HIS AVAILABILITY??

//TODO: SHOW WORKING DAYS IN A CALENDAR and when click show details

//TODO: SHOW TASKS IN A CALENDAR PER MONTH AND PER DEPARTMENT

//TODO: When we edit a task but we dont change anything and press save than i mustnt become unallocated

//TODO: FILTER TASKS BASED ON DATE FROM-TO DEPARTMENT MINIMUMSKILLLEVEL AND ALLOCATIONSTATUS ----- REMOVE UNALLOCATED TASKS PAGE

//TODO: MAKE A CALENDAR FOR ADMIN VIEW TO SEE EMPLOYEE AVAILABILITY PER DAY AND PER DEPARTMENT AND SKILL LEVEL

//TODO: EMAIL FAILURE EXCEPTION HANDLING