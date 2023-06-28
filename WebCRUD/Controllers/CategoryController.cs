using Microsoft.AspNetCore.Mvc;

namespace WebCRUD.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
