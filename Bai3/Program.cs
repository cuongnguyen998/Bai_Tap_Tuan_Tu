using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("P(x,y) = 4x^2y - 2xy + 6xy^2 - 13");
            Console.WriteLine();
            Console.Write("Mời nhập x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Mời nhập y = ");
            double y = double.Parse(Console.ReadLine());
            //double result = 4 * (x * x) * y - 2 * x * y + 6 * x * (y * y) - 13;
            double ketQua = 4 * Math.Pow(x, 2) * y - 2 * x * y + 6 * x * Math.Pow(y, 2) - 13;
            Console.WriteLine("Kết quả của P({0},{1}) = {2}",x,y,ketQua);
            Console.ReadLine();
        }
    }
}
