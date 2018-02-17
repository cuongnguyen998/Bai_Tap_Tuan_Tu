using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            TinhDiemTrungBinh();
            Console.ReadLine();
        }
        static void TinhDiemTrungBinh()
        {
            Console.WriteLine("Nhập điểm môn Toán: ");
            float math = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn Ly: ");
            float physic = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn Hóa: ");
            float chemistry = float.Parse(Console.ReadLine());
            float diemTongCong = math + physic + chemistry;
            Console.WriteLine("Điểm Tổng Cộng: {0}", diemTongCong);
            Console.WriteLine("Điểm Trung Bình: {0}", diemTongCong/3);
            
        }
    }
}
