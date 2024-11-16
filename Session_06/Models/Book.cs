using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace Session_06.Models
{
    public class Book
    {
        [DisplayName("Mã sách")]
        [StringLength(10)]
        public string BookId { get; set; }
        [DisplayName("Tên sách")]
        [StringLength(200)]
        public string Title { get; set; }
        [DisplayName("Tên sách")]
        [StringLength(200)]
        public string Author { get; set; }
        [DisplayName("Tác giả")]
        [StringLength(100)]
        public int? Release { get; set; }
        [DisplayName("Giá")]
        public double? Price { get; set; }
        [DisplayName("Mô tả")]
        public string Description {  get; set; }
        [DisplayName("Hình ảnh")]
        public string Picture {  get; set; }
        [DisplayName("Mã nhà sản xuất")]
        public int? Publishe { get; set; }
        [DisplayName("Mã loại")]
        public int? CategoryId { get; set; }
        //Tạo các quan hệ giữa các thực thể
        public Categogy Categogy { get; set; }
        public Publisher Publisher { get; set; }
    }
}
