using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TinhLaiSuat();
            Console.ReadLine();
        }
        static void TinhLaiSuat()
        {            
            Console.Write("Nhập lãi suất (%): ");
            float laiSuat = int.Parse(Console.ReadLine());
            Console.Write("Nhập số tiền gửi: ");
            int tienGui = int.Parse(Console.ReadLine());
            Console.Write("Nhập thời gian gửi (tháng): ");
            int thoiGian = int.Parse(Console.ReadLine());
            double tienLai = tienGui * ((laiSuat / 100) / 12) * thoiGian;
            Console.WriteLine("Tiền lãi sau {0} tháng là: {1}", thoiGian, tienLai);
        }
    }
}
