using Microsoft.AspNetCore.Mvc;

namespace KarmaApp.Controllers
{
	public class PagesController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
	}
}
