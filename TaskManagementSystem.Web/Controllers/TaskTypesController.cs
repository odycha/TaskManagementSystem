using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using TaskManagementSystem.Application.Services.TaskTypes;

namespace TaskManagementSystem.Web.Controllers;


public class TaskTypesController(ITaskTypesService _taskTypesService) : Controller
{
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task <IActionResult> Index(DateOnly? fromDate, DateOnly? toDate, TimeOnly? fromTime, TimeOnly? toTime,
        string? department, int? minimumSkillLevel, bool? isAllocatted, bool? isCompleted, bool? taskOutOfWorkingPeriod, bool? employeeNotified, bool noSuitableEmployee = false, string? taskName = null)
    {
        //get all tasks according to filters
        var viewData = await _taskTypesService.GetAll(fromDate, toDate, fromTime, toTime, department, minimumSkillLevel, isAllocatted, isCompleted);
        //returning with viewbag users filtering selection
        ViewBag.fromDate = fromDate;
        ViewBag.toDate = toDate;
        ViewBag.toTime = toTime;
        ViewBag.fromTime = fromTime;
        ViewBag.department = department;
        ViewBag.minimumSkillLevel = minimumSkillLevel;
        ViewBag.isAllocatted = isAllocatted;
        ViewBag.isCompleted = isCompleted;
        ViewBag.taskOutOfWorkingPeriod = taskOutOfWorkingPeriod;
		ViewBag.noSuitableEmployee = noSuitableEmployee;
        ViewBag.taskName = taskName;
        ViewBag.employeeNotified = employeeNotified;
        return View(viewData);
    }


    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> CalendarIndex(string? department, int? minimumSkillLevel, bool? isAllocatted, bool? isCompleted)

    {
        //get all tasks according to filters
        var viewData = await _taskTypesService.GetAll(null, null, null, null, department, minimumSkillLevel, isAllocatted, isCompleted);
        //returning with viewbag users filtering selection
        ViewBag.department = department;
        ViewBag.minimumSkillLevel = minimumSkillLevel;
        ViewBag.isAllocatted = isAllocatted;
        ViewBag.isCompleted = isCompleted;
        return View(viewData);
    }

    [Authorize]
    public async Task<IActionResult> StatisticsVisual(DateOnly? fromDate, DateOnly? toDate, TimeOnly? fromTime, TimeOnly? toTime)
    {
        var viewData = await _taskTypesService.GetAll(fromDate, toDate, fromTime, toTime, null, null, null, null);
        ViewBag.fromDate = fromDate;
        ViewBag.toDate = toDate;
        ViewBag.toTime = toTime;
        ViewBag.fromTime = fromTime;
        return View(viewData);
    }

    [Authorize]
    public async Task <IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var viewData = await _taskTypesService.Get(id.Value);
        if (viewData == null)
        {
            return NotFound();
        }
        return View(viewData);
    }
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    // GET:
    public async Task<IActionResult> Create()
    {
        return View();
    }

    // POST:
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TaskTypeCreateVM taskTypeCreate)
    {
        //TODO: I do not check if the Task exists because there can be 2 tasks with the same name and date - check if all fields the same?
        if (ModelState.IsValid)
        {
            try
            {
				await _taskTypesService.Create(taskTypeCreate);
			}
            catch (InvalidTimeInputException e)
            {
                ViewBag.invalidTime = true;
                return View(taskTypeCreate);
            }
            
            return RedirectToAction(nameof(Index));
        }
        return View(taskTypeCreate);
    }

    // GET:
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> Edit(int? id)
    {
        if(id == null)
        {
            return NotFound();
        }
        var taskType = await _taskTypesService.Get<TaskTypeEditVM>(id.Value);
        if(taskType == null)
        {
            return NotFound();
        }
        //If the task is completed redirect to home
        if (taskType.Completed == true)
        {
            return RedirectToAction("Index", "Home");
        }
        return View(taskType);
    }

    // POST:
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(TaskTypeEditVM taskTypeEdit)
    {
        bool employeeNotified = false;
        if (ModelState.IsValid)
        {
            try
            {
				employeeNotified = await _taskTypesService.Edit(taskTypeEdit);
			}
            catch(InvalidTimeInputException e)
            {
                ViewBag.invalidTime = true;
                return View(taskTypeEdit);
			}
            return RedirectToAction(nameof(Index), new {employeeNotified});
        }
        return View(taskTypeEdit);
    }

    // GET:
    //Delete confirmation page
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var taskType = await _taskTypesService.Get<TaskTypeReadOnlyVM>(id.Value); //TODO: why use .Value (because nullable?)
        if(taskType == null)
        {
            return NotFound();
        }
        //If the task is completed redirect to home
        if (taskType.Completed == true)
        {
            return RedirectToAction("Index", "Home");
        }
        return View(taskType);
    }

    // POST:
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        bool employeeNotified = await _taskTypesService.Remove(id);
        return RedirectToAction(nameof(Index), new {employeeNotified});
    }

    //Edit actions don't require two distinct methods (Edit and EditConfirmed) because the GET and POST are inherently tied to the same logical operation: updating data.
    //Delete actions, being more destructive, require a confirmation step and thus benefit from the two-method approach to separate the "intent to delete" from the "action of deletion."

}




//TODO: Create on click workday on calendar
//TODO: At employee view unallocate button for a task
