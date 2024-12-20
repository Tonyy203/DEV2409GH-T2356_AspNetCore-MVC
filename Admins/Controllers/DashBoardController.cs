using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Areas.Admins.Controllers
{
    //[Area("Admins")]
    public class DashBoardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
