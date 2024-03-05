using Microsoft.AspNetCore.Mvc;

namespace KarmaApp.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Details()
		{
			return View();
		}
	}
}
