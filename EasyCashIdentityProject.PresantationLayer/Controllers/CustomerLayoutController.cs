using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresantationLayer.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
