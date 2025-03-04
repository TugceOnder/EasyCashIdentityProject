using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresantationLayer.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
