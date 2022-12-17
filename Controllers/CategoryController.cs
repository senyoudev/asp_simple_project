using Microsoft.AspNetCore.Mvc;

namespace freecodecamp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
