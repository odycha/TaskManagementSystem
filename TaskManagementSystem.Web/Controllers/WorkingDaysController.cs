using Microsoft.AspNetCore.Authorization;
using TaskManagementSystem.Application.Models.WorkingDays;

namespace TaskManagementSystem.Web.Controllers;
[Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
public class WorkingDaysController(IWorkingDaysService _workingDaysService) : Controller
{
    public async Task<IActionResult> Index()
    {
        var viewData = await _workingDaysService.GetAll();
        return View(viewData);
    }

    //Get
    public async Task<IActionResult> Create()
    {
        return View();
    }
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(WorkingDayCreateVM workingDayCreate)
    {
        if (ModelState.IsValid)
        {
            _workingDaysService.Create(workingDayCreate);
            return (RedirectToAction(nameof(Index)));
        }
        return View(workingDayCreate);
    }

	//Get
	public async Task<IActionResult> Delete(int? id)
	{
        if(id == null)
        {
            return NotFound();
        }
        var workingDay = await _workingDaysService.Get<WorkingDayReadOnlyVM>(id.Value);
        if(workingDay == null)
        {
			return NotFound();
		}
		return View(workingDay);
	}
	//Post
	[HttpPost, ActionName("Delete")]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> DeleteConfirmed(int id)
	{
        await _workingDaysService.Remove(id);
        return RedirectToAction(nameof(Index));
    }
}





