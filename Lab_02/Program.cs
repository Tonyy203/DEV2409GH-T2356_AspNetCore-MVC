namespace Lab01_2
{
    /// <summary>
    /// Author  : Tuấn Tài
    /// Date    : 14/10/2024
    /// Objective: CHương trình minh họa cách sử dụngbiến, hằng số , kiểu dữ liệu,...
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Main:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Khai báo biến
            int id = 1;
            string name = "David Tài Nguyễn";
            byte age = 22;
            char gender = 'M';

            // Khai báo biến hằng
            const float percent = 75.50F;

            //Hiển thị giá trị
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mã số : {0}", id);
            Console.WriteLine("Tên sinh viên : {0}", name);
            Console.WriteLine("Tuổi :" + age);
            Console.WriteLine("Giới tính :" + gender);
            Console.WriteLine("Percentage : {0}", percent);
        }
    }
}