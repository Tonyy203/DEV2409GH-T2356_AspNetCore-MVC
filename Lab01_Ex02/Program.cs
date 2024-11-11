/// <summary>
/// Author  : Tuấn Tài
/// Date    : 14/10/2024
/// Objective: 
/// </summary>

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=System.Text.Encoding.UTF8;
        Console.WriteLine("Viết các chương trình thực hiên các yêu cầu sau");
        //Nhập các biến
        string maSV;
        string hoVaTen;
        DateTime ngaySinh;
        string diaChi;
        string dienThoai;
        string email;

        //Gán giá trị
        maSV = "011";
        hoVaTen = "Nguyễn Tài";
        ngaySinh = DateTime.Now;
        diaChi = "ACX Long Biên";
        email = "AAA@email.com";

        //Hiên thị thông tin
        Console.WriteLine("===Thông tin cá nhân===");
        Console.WriteLine("Mã sinh viên :" + maSV);
        Console.WriteLine("Họ và tên {0}:"+ hoVaTen);
        Console.WriteLine("Ngày sinh: " + string.Format("{0:dd/MM/yyyy}", ngaySinh)); 
        Console.WriteLine("Địa chỉ : {0}", diaChi);
        Console.WriteLine("Email :" +email);
    }
}