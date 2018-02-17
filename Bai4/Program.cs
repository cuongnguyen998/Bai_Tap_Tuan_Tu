using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên khách hàng: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập chỉ số điện tháng trước: ");
            int chiSoCu = int.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số điện tháng này: ");
            int chiSoMoi = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hóa đơn tiền điện");            
            Console.WriteLine("Khách hàng: {0}", hoTen);
            Console.WriteLine("Chỉ số cũ: {0} KWH", chiSoCu);
            Console.WriteLine("Chỉ số mới: {0} KWH", chiSoMoi);
            Console.WriteLine("Tiêu thụ: {0} KWH", chiSoMoi-chiSoCu);
            Console.WriteLine("Tiền điện: {0} VND", (chiSoMoi-chiSoCu)*452.45);
            Console.WriteLine("Yêu cầu tiết kiệm điện");
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();
        }
    }
}
