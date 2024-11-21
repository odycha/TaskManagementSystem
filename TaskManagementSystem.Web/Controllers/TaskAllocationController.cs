using Microsoft.AspNetCore.Authorization;
using TaskManagementSystem.Application.Services.TaskAllocations;

namespace TaskManagementSystem.Web.Controllers;

[Authorize]
public class TaskAllocationController(ITaskAllocationsService _taskAllocationService) : Controller
{
	//see all unallocated tasks
	public async Task<IActionResult> Index(bool noSuitableEmployee = false, string? taskName = null)
	{
		var unallocatedTasks = await _taskAllocationService.GetAllUnallocatedTasks();
		if (unallocatedTasks == null)
		{
			return NotFound();
		}
		ViewBag.noSuitableEmployee = noSuitableEmployee;
		ViewBag.taskName = taskName;
		return View(unallocatedTasks);
	}

	//Get
	//a task will be allocated to the lower skilled employee possible, who is available and in the same department
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
	public async Task<IActionResult> AllocateTask(int id)
	{
		try 
		{ 
			await _taskAllocationService.AllocateTask(id);
		}
		catch(WorkingDayNotFoundException e)
		{
			return RedirectToAction("Create", "WorkingDays", new { comingFromAllocation = true , workingDayDate = e.MissingDate });
        }
		catch (NoSuitableEmployeeException e)
		{
			return RedirectToAction("Index", new { noSuitableEmployee = true , taskName =  e.Message });
		}

		return RedirectToAction(nameof(Index));
	}
	
	//View All Employees
    [Authorize(Roles = Roles.Administrator)]
    public async Task<IActionResult> ViewEmployees()
	{
		var employees = await _taskAllocationService.GetEmployees();
		return View(employees);
	}

	[Authorize(Roles = Roles.Employee)]
	public async Task<IActionResult> ViewSignedInEmployeeAllocations()
	{
		var allocations = await _taskAllocationService.GetEmployeeAllocations();
		return View(allocations);
	}

	//View allocations for a specific employee
	[Authorize(Roles = Roles.Administrator)]
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







}


//TODO: View all allocations per date

//TODO: Unallocate task AT TASKS PAGE

//TODO: WHEN LOOKING AT AN EMPLOYEE EXCEPT FROM VIEWING ALLOCATIONS - SEE ALSO A CALENDAR WITH HIS AVAILABILITY

//TODO: SHOW WORKING DAYS IN A CALENDAR 

//TODO: SHOW TASKS IN A CALENDAR PER MONTH AND PER DEPARTMENT

//TODO: When we edit a task but we dont change anything and press save than i mustnt become unallocated