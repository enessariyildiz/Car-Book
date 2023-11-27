using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutUsComponents
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
