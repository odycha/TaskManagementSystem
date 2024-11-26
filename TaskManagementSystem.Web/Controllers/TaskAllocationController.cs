using Microsoft.AspNetCore.Authorization;
using TaskManagementSystem.Application.Services.TaskAllocations;

namespace TaskManagementSystem.Web.Controllers;

[Authorize]
public class TaskAllocationController(ITaskAllocationsService _taskAllocationService) : Controller
{

	//Get
	//a task will be allocated to the lower skilled employee possible, who is available and in the same department
	[Authorize(Roles = Roles.Administrator)]
	public async Task<IActionResult> AllocateTask(int? id)
	{
		if (id == null)
		{
			return NotFound();
		}
		var taskType = await _taskAllocationService.GetUnallocatedTask(id.Value);
		if (taskType == null)
		{
			return NotFound();
		}
		return View(taskType);
	}

	//Post
	[HttpPost]
	[AutoValidateAntiforgeryToken]
	[Authorize(Roles = Roles.Administrator)]
	public async Task<IActionResult> AllocateTask(int id)
	{
		try
		{
			await _taskAllocationService.AllocateTask(id);
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

		return RedirectToAction("Index", "TaskTypes");
	}

	//View All Employees
	[Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
	public async Task<IActionResult> ViewEmployees(string? department, int? minimumSkillLevel)
	{
		var employees = await _taskAllocationService.GetEmployees(department, minimumSkillLevel);
		ViewBag.department = department;
		ViewBag.minimumSkillLevel = minimumSkillLevel;
		return View(employees);
	}

	[Authorize(Roles = Roles.Employee)]
	public async Task<IActionResult> ViewSignedInEmployeeAllocations()
	{
		var allocations = await _taskAllocationService.GetEmployeeAllocations();
		return View(allocations);
	}

	//View allocations for a specific employee
	[Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
	//!!!!!!!!!!!!!!!!!!!!!!!!!!!!SOSOSOSOSOSOSOSOSOSO!!!! THE ID IN THE VIEW MUST HAVE THE SAME NAME WITH THE ACTION
	public async Task<IActionResult> ViewEmployeeAllocations(string id)
	{
		if (id == null)
		{
			return NotFound();
		}
		var allocations = await _taskAllocationService.GetAllocations(id);
		return View(allocations);
	}


	//get
	[Authorize]
	public async Task<IActionResult> SendMailToEmployee(string? id)
	{
		var employeeVm = await _taskAllocationService.GetEmployee(id);
		return View(employeeVm);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	[Authorize]
	public async Task<IActionResult> SendMailToEmployee(EmployeeEmailVM model)
	{
		await _taskAllocationService.SendEmail(model);
		// Check if the "Referer" header exists
		var referer = Request.Headers.Referer.ToString();
		if (!string.IsNullOrEmpty(referer))
		{
			// Redirect back to the previous page
			return Redirect(referer);
		}

		// Fallback if the referer is not available
		return RedirectToAction("Index", "TaskTypes");
	}






	//get
	[Authorize(Roles = Roles.Administrator)]
	public async Task<IActionResult> Deallocate(int? id)
	{
		if(id == null)
		{
			return NotFound();
		}
		var allocationVm = await _taskAllocationService.GetAllocation(id.Value);
		if (allocationVm == null)
		{
			return NotFound();
		}
		return View(allocationVm);
	}

	//post
	[HttpPost, ActionName("Deallocate")]
	[ValidateAntiForgeryToken]
	[Authorize(Roles = Roles.Administrator)]
	public async Task<IActionResult> DeallocateConfirmed(int id)
	{
		await _taskAllocationService.Remove(id);
		return (RedirectToAction("Index", "TaskTypes"));
	}
}




//TODO: Unallocate task AT TASKS PAGE

//TODO: WHEN LOOKING AT AN EMPLOYEE EXCEPT FROM VIEWING ALLOCATIONS - SEE ALSO A CALENDAR WITH HIS AVAILABILITY??

//TODO: SHOW WORKING DAYS IN A CALENDAR and when click show details

//TODO: SHOW TASKS IN A CALENDAR PER MONTH AND PER DEPARTMENT

//TODO: When we edit a task but we dont change anything and press save than i mustnt become unallocated

//TODO: FILTER TASKS BASED ON DATE FROM-TO DEPARTMENT MINIMUMSKILLLEVEL AND ALLOCATIONSTATUS ----- REMOVE UNALLOCATED TASKS PAGE

//TODO: MAKE A CALENDAR FOR ADMIN VIEW TO SEE EMPLOYEE AVAILABILITY PER DAY AND PER DEPARTMENT AND SKILL LEVEL