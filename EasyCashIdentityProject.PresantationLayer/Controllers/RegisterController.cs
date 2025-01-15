
using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace EasyCashIdentityProject.PresantationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto) // solid prensiperinde ne gerekiyorsa onu çağırıp kullanacağız.
        {
            if(ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserRegisterDto.Username,
                    Name = appUserRegisterDto.Name,
                    Surname = appUserRegisterDto.Surname,
                    Email = appUserRegisterDto.EMail,
                  
                };
                var result= await _userManager.CreateAsync(appUser,appUserRegisterDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "ConfirmMail");
                }
       
            }
            return View();
        }
    }
}
