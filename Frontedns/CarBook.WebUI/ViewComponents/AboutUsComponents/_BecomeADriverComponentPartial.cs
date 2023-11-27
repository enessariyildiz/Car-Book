using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutUsComponents
{
    public class _BecomeADriverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
