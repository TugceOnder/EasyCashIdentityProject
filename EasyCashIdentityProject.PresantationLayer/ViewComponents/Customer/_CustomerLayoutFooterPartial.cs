using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresantationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
