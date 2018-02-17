using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;            
            string hoVaTen;
            int namSinh;
            Console.Write("Mời nhập vào họ tên của bạn: ");
            hoVaTen = Console.ReadLine();
            Console.Write("Mời nhập năm sinh của bạn: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Tên của bạn là: {0}", hoVaTen);
            Console.WriteLine("Tuổi hiện tại của bạn là: {0}", 2018-namSinh);
            Console.WriteLine("Tuổi của bạn ở năm 2025 là: {0}", 2025-namSinh);
            Console.ReadLine();            
        }
    }
}
