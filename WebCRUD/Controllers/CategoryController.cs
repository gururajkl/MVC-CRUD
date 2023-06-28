using Microsoft.AspNetCore.Mvc;
using WebCRUD.Data;
using WebCRUD.Models;

namespace WebCRUD.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext db;

        public CategoryController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categoriesFromDatabase = db.Categories;    
            return View(categoriesFromDatabase);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
