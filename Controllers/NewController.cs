using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevXuongMoc.Controllers
{
    public class NewController : Controller
    {
        private readonly DevXuongMocSqlContext _context;
        public NewController(DevXuongMocSqlContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.News
          .Select(news => new News
          {
              Id = news.Id,
              Title = news.Title ?? "Không có tiêu đề",
              Image = news.Image ?? "images/default-image.jpg",
              UpdatedDate = news.UpdatedDate ?? DateTime.Now // Gán ngày hiện tại nếu null
          })
          .ToListAsync();

            return View(data);

        }
    }
}
