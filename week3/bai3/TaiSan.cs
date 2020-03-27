using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class TaiSan
    {
        string TenTaiSan;
        int SoLuong;
        string TinhTrang;
        public void Nhap()
        {
            Console.Write("Nhap Ten Tai san: ");
            TenTaiSan = Console.ReadLine();
            Console.Write("Nhap So luong : ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap tinh trang : ");
            TinhTrang = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("\t{0}\t\t{1}\t\t{2}",TenTaiSan,SoLuong,TinhTrang);
        }
        public int getsoluong()
        {
            return SoLuong;
        }
    }
}
