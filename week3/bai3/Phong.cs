using System;
using System.Collections.Generic;
using System.Text;
namespace baitap
{
    class Phong
    {
        string MaPhong, TruongPhong,TenPhong;
        public void Nhap()
        {
            Console.Write("Nhap Ma Phong : ");
            MaPhong = Console.ReadLine();
            Console.Write("Nhap Ten Phong : ");
            TenPhong = Console.ReadLine();
            Console.Write("Nhap Truong Phong : ");
            TruongPhong = Console.ReadLine();
        }
        public string getMaPhong()
        {
            return MaPhong;
        }
        public string getTenPhong()
        {
            return TenPhong;
        }
        public string getTruongPhong()
        {
            return TruongPhong;
        }
    }
}
