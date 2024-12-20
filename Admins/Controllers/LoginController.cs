using Microsoft.AspNetCore.Mvc;
using DevXuongMoc.Models;
using System.Text;
using DevXuongMoc.Areas.Admins.Models;

namespace DevXuongMoc.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class LoginController : Controller
    {
        public DevXuongMocdbContext _context;

        public LoginController(DevXuongMocdbContext context)
        {
            _context = context;
        }

        [HttpGet]// get, hiển thị form để nhập dữ liệu
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] // POST -> khi submit form
        public IActionResult Index(Login model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ.");
                return View(model);
            }

            /// sẽ xử lý login phần đăng nhập tại đây
            var pass = model.Password;
            var dataLogin = _context.AdminUsers.Where(x => x.Email.Equals(model.Email) && x.Password.Equals(pass)).FirstOrDefault();
            if (dataLogin != null)
            {
                HttpContext.Session.SetString("AdminLogin", model.Email);
                return RedirectToAction("Index", "Dashboard");  
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không chính xác.");
                return View(model);
            }
            return View(model); // trả về trạng thái lỗi
        }
        [HttpGet] // thoát đăng nhập, huỷ session
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin"); // huỷ session với key AdminLogin đã lưu trước đó

            return RedirectToAction("Index");
        }
    }
}
