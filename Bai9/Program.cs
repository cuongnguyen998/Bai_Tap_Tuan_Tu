using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ của người thứ nhất: ");
            string lastName1 = Console.ReadLine();
            Console.Write("Nhập họ của người thứ hai: ");
            string lastName2 = Console.ReadLine();
            Console.Write("Nhập tên của người thứ nhất: ");
            string firstName1 = Console.ReadLine();
            Console.Write("Nhập tên của người thứ hai: ");
            string firstName2 = Console.ReadLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Thân gửi {0} {1},", lastName1, firstName1);
            Console.WriteLine();
            Console.WriteLine("Nhân dịp sinh nhật của {0}, cho phép {1} gởi ", firstName1, firstName2);
            Console.WriteLine("đến {0} những lời chúc tốt đẹp nhất về sức khỏe,",firstName1);
            Console.WriteLine("hạnh phúc và thành công trong mọi lãnh vực.");
            Console.WriteLine("Gởi lời thăm sức khỏe hai bác của {0}.", firstName1);
            Console.WriteLine();
            Console.WriteLine("Bạn của {0}", firstName1);
            Console.WriteLine(lastName2+" "+firstName2);
            Console.WriteLine();
            Console.WriteLine("TB: Ba má của {0} thường nhắc đến {1} luôn", firstName2, firstName1);
            Console.ReadLine();
        }
    }
}
