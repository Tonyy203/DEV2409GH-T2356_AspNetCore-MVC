namespace Lesson01
{
    /// <summary>
    /// Author  : Tuấn Tài
    /// Date    : 14/10/2024
    /// Chương trình C# Đầu tiên
    /// In ra thông tin giới thiệu bản thân
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Main:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Lệnh in ra màn hình dòng văn bản và sau đó xuống dòng
            Console.WriteLine("Họ và tên: Nguyễn Tuấn Tài");
            // Lệnh in có định dạng
            Console.WriteLine("Ngày sinh: {0}", "07/11/2003");
            Console.Write("Địa chỉ: ACX, Phố A  \n");
            Console.WriteLine("Điện thoại: 0978611889");
            Console.WriteLine("Email:akaij@gmail.com");
        }
    }
}