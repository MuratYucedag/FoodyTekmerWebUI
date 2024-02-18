using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.ViewComponents
{
    public class ScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
