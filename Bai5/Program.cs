using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ChuViVaDienTichHinhTron();
            Console.ReadLine();
        }
        static void ChuViVaDienTichHinhTron()
        {
            Console.Write("Nhập bán kính r = ");
            double banKinh = double.Parse(Console.ReadLine());
            double chuVi = 2 * banKinh * Math.PI;
            double dienTich = banKinh * banKinh * Math.PI;
            Console.WriteLine("Chu vi hình tròn là: {0}", chuVi);
            Console.WriteLine("Diện tích hình tròn là: {0}", dienTich);
        }
    }
}
