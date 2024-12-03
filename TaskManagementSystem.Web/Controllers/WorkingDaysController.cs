using Microsoft.AspNetCore.Authorization;
using TaskManagementSystem.Application.Models.WorkingDays;

namespace TaskManagementSystem.Web.Controllers;

public class WorkingDaysController(IWorkingDaysService _workingDaysService) : Controller
{
    [Authorize]
    public async Task<IActionResult> Index()
    {
        var viewData = await _workingDaysService.GetAll();
        return View(viewData);
    }


    //Get
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> Create(
        bool comingFromAllocation = false, 
        DateOnly? workingDayDate = null)
    {
        ViewBag.ComingFromAllocation = comingFromAllocation;
        ViewBag.workingDayDate = workingDayDate;
        
        return View();
    }

    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> Create(WorkingDayCreateVM workingDayCreate)
    {
        if (ModelState.IsValid)
        {
            try
            {
               await _workingDaysService.Create(workingDayCreate);
				
			}
            catch(SameDateExistsException e)
            {
				ViewBag.sameDateExists = true;
				return View(workingDayCreate);
            }
            catch(InvalidTimeInputException e)
            {
				ViewBag.ivalidTimeInput = true;
				return View(workingDayCreate);
			}
            return (RedirectToAction(nameof(Index)));
		}
        return View(workingDayCreate);
    }

    //Get
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> Edit (int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var workingDay = await _workingDaysService.Get<WorkingDayCreateVM>(id.Value);
        if (workingDay == null)
        {
            return NotFound();
        }
        return View(workingDay);
    }

    //post
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> Edit (WorkingDayCreateVM model)
    {
        if (ModelState.IsValid)
        {
            try
            {
                await _workingDaysService.Edit(model);
            }
            catch (SameDateExistsException e)
            {
                ViewBag.sameDateExists = true;
                return View(model);
            }
            catch (InvalidTimeInputException e)
            {
                ViewBag.ivalidTimeInput = true;
                return View(model);
            }
            return (RedirectToAction(nameof(Index)));
        }
        return View(model);
	}

    //Get
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
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
    [Authorize(Roles = $"{Roles.Administrator},{Roles.TaskManager}")]
    public async Task<IActionResult> DeleteConfirmed(int id)
	{
        await _workingDaysService.Remove(id);
        return RedirectToAction(nameof(Index));
    }
}






//TODO: ONCLICK IN CALENDAR SHOW WORKING DAY DETAILS

//TODO: FOR A WORKING DAY ADD WORKING HOURS AND MAYBE A TASK COULD BE ASSIGNED TO A TIME SLOT EG: 0900-1200