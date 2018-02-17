using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào chiều dài của cạnh góc vuông thứ nhất: ");
            float vuong1 = float.Parse(Console.ReadLine());
            Console.Write("Nhập vào chiều dài của cạnh góc vuông thứ hai: ");
            float vuong2 = float.Parse(Console.ReadLine());
            double huyen = Math.Sqrt(Math.Pow(vuong1,2)+Math.Pow(vuong2,2));
            Console.WriteLine("Chiều dài cạnh huyền là: {0}", huyen);
            Console.WriteLine("Chu vi là: {0}", vuong1+vuong2+huyen);
            Console.WriteLine("Diện tích là: {0}", (vuong1*vuong2)/2);
            Console.ReadLine();
        }
    }
}
