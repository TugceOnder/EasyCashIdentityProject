using EasyCashIdentityProject.EntityLayer.Concrete;
using EasyCashIdentityProject.PresantationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace EasyCashIdentityProject.PresantationLayer.Controllers
{
	public class LoginController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;
		private readonly UserManager<AppUser> _userManager;

		public LoginController (SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task <IActionResult> Index(LoginViewModel loginViewModel)
		{
			// 5 kere yanlış girdiğinde engellenecek
		    var result = await _signInManager.PasswordSignInAsync(loginViewModel.Username, 
				loginViewModel.Password,false,true);

			if (result.Succeeded)
			{
				var user = await _userManager.FindByNameAsync(loginViewModel.Username);
				if(user.EmailConfirmed == true)
				{
					return RedirectToAction("Index", "MyAccounts");
				}
				else
				{

				}
			}
			return View();
		}
	}
}
