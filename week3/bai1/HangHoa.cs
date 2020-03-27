using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    public class HangHoa
    {
        string MaHang, TenHang;
        double DonGia;
        int SoLuong;

        public void Nhap()
        {
            Console.Write("Nhap Ma hang : ");
            MaHang = Console.ReadLine();
            Console.Write("Nhap Ten Hang : ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap Don Gia : ");
            DonGia = int.Parse(Console.ReadLine());
            Console.Write("Nhap So luong : ");
            SoLuong = int.Parse(Console.ReadLine());
        }
        public double ThanhTien()
        {
            return SoLuong * DonGia;
        }
        public void Xuat()
        {
            Console.WriteLine("\t\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}" ,MaHang,TenHang,DonGia,SoLuong,ThanhTien());
        }
    }
}
