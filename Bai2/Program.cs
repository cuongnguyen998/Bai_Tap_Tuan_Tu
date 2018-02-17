using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Y = 3x^2 + 4x + 7");
            Console.Write("Nhập X bất kì: x = ");
            double x = double.Parse(Console.ReadLine());
            double y = 3 * (x * x) + 4 * x + 7;
            Console.WriteLine("Kết quả của đa thức: y = {0}", y);
            Console.ReadLine();

        }
    }
}
