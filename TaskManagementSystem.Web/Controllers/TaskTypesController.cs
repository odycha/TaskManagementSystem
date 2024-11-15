using TaskManagementSystem.Application.Services.TaskTypes;

namespace TaskManagementSystem.Web.Controllers;

public class TaskTypesController(ITaskTypesService _taskTypesService) : Controller
{
    public async Task <IActionResult> Index()
    {
        var viewData = await _taskTypesService.GetAll();
        return View(viewData);
    }

    public async Task <IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var viewData = await _taskTypesService.Get<TaskTypeReadOnlyVM>(id.Value);
        if (viewData == null)
        {
            return NotFound();
        }
        return View(viewData);
    }

    // GET:
    public async Task<IActionResult> Create()
    {
        return View();
    }

    // POST:
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TaskTypeCreateVM taskTypeCreate)
    {
        //TODO: I do not check if the Task exists because there can be 2 tasks with the same name and date - check if all fields the same?
        if (ModelState.IsValid)
        {
            await _taskTypesService.Create(taskTypeCreate);
            return RedirectToAction(nameof(Index));
        }
        return View(taskTypeCreate);
    }

    // GET:
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
        return View(taskType);
    }

    // POST:
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(TaskTypeEditVM taskTypeEdit)
    {
        if (ModelState.IsValid)
        {
            await _taskTypesService.Edit(taskTypeEdit);
            return RedirectToAction(nameof(Index));
        }
        return View(taskTypeEdit);
    }

    // GET:
    //Delete confirmation page
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
        return View(taskType);
    }

    // POST:
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _taskTypesService.Remove(id);
        return RedirectToAction(nameof(Index));
    }


}
