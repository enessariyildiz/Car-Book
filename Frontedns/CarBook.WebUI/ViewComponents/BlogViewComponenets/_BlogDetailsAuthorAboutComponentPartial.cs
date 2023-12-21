using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace CarBook.WebUI.ViewComponents.BlogViewComponenets
{
    public class _BlogDetailsAuthorAboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
