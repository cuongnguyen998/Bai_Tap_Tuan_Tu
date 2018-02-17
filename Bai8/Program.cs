using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập chiều dài cạnh hình vuông: ");
            double canh = double.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi hình vuông là: {0}", 4*canh);
            double banKinh = (4 * canh) / (2 * Math.PI);
            Console.WriteLine("Bán kính hính tròn là: {0}", banKinh);
            Console.ReadLine();
        }
    }
}
