using System;
using baitap;
namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            TamThucBacHai f1 = new TamThucBacHai(1,-3,2);
            TamThucBacHai f2 = new TamThucBacHai(142, -245, 100);
            f1 = -f1;
            f2 = -f2;
            Console.Write("tam thuc 1 :");
            f1.Fx();
            Console.Write("tam thuc 2 :");
            f2.Fx();
            TamThucBacHai tong = f1 + f2;
            TamThucBacHai Hieu = f1 - f2;
            Console.Write("Tong = ");
            tong.Fx();
            Console.Write("Hieu = ");
            Hieu.Fx();
        }
        
    }
}
