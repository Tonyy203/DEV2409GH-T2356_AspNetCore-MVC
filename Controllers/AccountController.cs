using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevXuongMoc.Controllers
{
    public class AccountController : Controller
    {
        private readonly DevXuongMocSqlContext _context;
        private readonly ILogger<AccountController> _logger;
        public AccountController(DevXuongMocSqlContext context, ILogger<AccountController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Đăng ký
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Customer user)
        {
            // Kiểm tra nếu email đã tồn tại
            var existingUser = await _context.Customer
                .FirstOrDefaultAsync(u => u.Email == user.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError("Email", "Email already exists.");
                return View(user);
            }

            // Tạo ID ngẫu nhiên
            user.Id = GenerateRandomId(10);  // Tạo ID ngẫu nhiên với độ dài 10 ký tự

            // Thêm người dùng vào cơ sở dữ liệu
            _context.Customer.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Login");
        }

        // Đăng nhập
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không hợp lệ.");
                return View();
            }

            // Kiểm tra thông tin đăng nhập
            var dataLogin = _context.Customer
                .FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password));

            if (dataLogin != null)
            {
                // Đăng nhập thành công -> Thiết lập cookie
                var cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    Expires = DateTime.UtcNow.AddDays(7) // Cookie có hiệu lực trong 7 ngày
                };
                Response.Cookies.Append("UserLogin", dataLogin.Email, cookieOptions);

                // Chuyển hướng sau khi đăng nhập thành công
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Đăng nhập thất bại
                ModelState.AddModelError(string.Empty, "Thông tin đăng nhập không chính xác.");
                return View();
            }
        }

        // Đăng xuất
        public IActionResult Logout()
        {
            Response.Cookies.Delete("UserLogin"); // Xóa cookie UserLogin
            return RedirectToAction("Login");
        }
        // Phương thức tạo ID ngẫu nhiên
        private string GenerateRandomId(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Range(0, length)
                .Select(_ => chars[random.Next(chars.Length)])
                .ToArray());
        }
    }
}
