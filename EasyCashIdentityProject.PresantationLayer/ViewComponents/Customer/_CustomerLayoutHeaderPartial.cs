using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresantationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
