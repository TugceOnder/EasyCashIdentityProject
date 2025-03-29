using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresantationLayer.Controllers
{
    public class MyLastProcessController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}

