using Microsoft.AspNetCore.Mvc;

namespace Lesson07_Assignment.Areas.Admins.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
