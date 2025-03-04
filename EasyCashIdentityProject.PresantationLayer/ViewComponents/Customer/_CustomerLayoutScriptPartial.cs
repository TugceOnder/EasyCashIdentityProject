using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresantationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View();
        }
    }
}
