using FoodyTekmerDataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmerWebUI.Controllers
{
    public class CategoryController : Controller
    {
        FoodyContext context = new FoodyContext();
        public IActionResult Index()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
    }
}
