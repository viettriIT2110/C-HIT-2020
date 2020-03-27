using System;
using baitap;
namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            Phieu phieukiemketaisan = new Phieu();
            phieukiemketaisan.Nhap();
            Console.WriteLine();
            phieukiemketaisan.Xuat();
            Console.ReadKey();
        }
        
    }
}
