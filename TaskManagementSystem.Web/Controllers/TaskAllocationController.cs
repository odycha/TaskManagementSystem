using Microsoft.AspNetCore.Authorization;
using TaskManagementSystem.Application.Services.TaskAllocations;

namespace TaskManagementSystem.Web.Controllers;

[Authorize]
public class TaskAllocationController(ITaskAllocationsService _taskAllocationService) : Controller
{
	//see all unallocated tasks
	public async Task<IActionResult> Index()
	{
		var unallocatedTasks = await _taskAllocationService.GetAllUnallocatedTasks();
		if (unallocatedTasks == null)
		{
			return NotFound();
		}
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
		await _taskAllocationService.AllocateTask(id);
		return RedirectToAction(nameof(Index));
	}
	
	//View All Employees
    [Authorize(Roles = Roles.Administrator)]
    public async Task<IActionResult> ViewEmployees()
	{
		var employees = await _taskAllocationService.GetEmployees();
		return View(employees);
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
//TODO: View allocations for signed in employee
//TODO: Unallocate task
//TODO ADMIN VIEW EMPLOYEE LIST AND ALLOCATIONS PER EMPLOYEE - LIKE EmployeeAllocationVM