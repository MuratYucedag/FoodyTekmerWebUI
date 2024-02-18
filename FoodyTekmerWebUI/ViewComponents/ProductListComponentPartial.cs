using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.ViewComponents
{
    public class ProductListComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
