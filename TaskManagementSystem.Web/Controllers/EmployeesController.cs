using Microsoft.AspNetCore.Mvc;

namespace TaskManagementSystem.Web.Controllers
{
	public class EmployeesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
