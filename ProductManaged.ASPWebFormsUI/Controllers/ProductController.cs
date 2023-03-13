using Microsoft.AspNetCore.Mvc;

namespace ProductManaged.ASPWebFormsUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
