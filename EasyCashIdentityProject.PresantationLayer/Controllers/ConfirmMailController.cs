using EasyCashIdentityProject.PresantationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresantationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		[HttpGet]
		public IActionResult Index(int id)
		{
			var value = TempData["Mail"];
			ViewBag.v = value + "aaa";
			return View();
		}

		[HttpPost]
		public IActionResult Index(ConfirmMailViewModel confirmMailViewModel)
		{
			return View();
		}
		
	}
}
