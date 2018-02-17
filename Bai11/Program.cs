using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên khách hàng: ");
            string ten = Console.ReadLine();
            Console.Write("Giá phòng (ngày/đêm): ");
            double giaPhong = int.Parse(Console.ReadLine());
            Console.Write("Ngày thuê (mm/đd/yy): ");
            DateTime ngayThue = DateTime.Parse(Console.ReadLine());
            Console.Write("Ngày trả (mm/dd/yy): ");
            DateTime ngayTra = DateTime.Parse(Console.ReadLine());
            TimeSpan ngayO = ngayTra - ngayThue;
            double tienO = giaPhong * ngayO.TotalDays;
            Console.Write("Số bữa ăn: ");
            int buaAn = int.Parse(Console.ReadLine());
            Console.Write("Đơn giá 1 bữa ăn: ");
            int donGia = int.Parse(Console.ReadLine());
            Console.Write("Phí phục vụ: ");
            int phucVu = int.Parse(Console.ReadLine());
            Console.WriteLine("\n***************************************************");
            Console.WriteLine("***********************");
            Console.WriteLine("Khách sạn Five Stars");
            Console.WriteLine("Hóa đơn khách sạn");
            Console.WriteLine("Quí ông/bà: {0}", ten);
            Console.WriteLine("Số ngày ở: {0}                     Số bữa ăn: {1}", ngayO.TotalDays, buaAn);
            Console.WriteLine("Tiền ở: {0}                        Tiền ăn: {1}              Phí phục vụ: {2}", tienO, donGia * buaAn, phucVu);
            Console.WriteLine("Tổng cộng: {0}", tienO + (donGia * buaAn) + phucVu);
            Console.WriteLine("Hân hạnh phục vụ quí khách");
            Console.WriteLine("****************************************************");                       
            Console.ReadLine();
            


        }
    }
}
