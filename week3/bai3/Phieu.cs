using System;
using System.Collections.Generic;
using System.Text;
using baitap;
namespace baitap
{
    class Phieu
    {
        string MaPhieu;
        Date ngaythangnam = new Date();
        Phong phongs = new Phong();
        NhanVien nv = new NhanVien();
        TaiSan[] ts;
        int n;
        public void Nhap()
        {
            Console.Write("Nhap Ma Phieu : ");
            MaPhieu = Console.ReadLine();
            ngaythangnam.Nhap();
            nv.Nhap();
            phongs.Nhap();
            Console.Write("Nhap so luong tai san: ");
            n = int.Parse(Console.ReadLine());
            ts = new TaiSan[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\tNhap tai san thu {0} ", i + 1);
                ts[i] = new TaiSan();
                ts[i].Nhap();
            }
        }
        public int TongSl()
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += ts[i].getsoluong();
            }
            return tong;
        }
        public void Xuat()
        {
            Console.WriteLine("\t\t\tPHIEU KIEM KE TAI SAN ");
            Console.Write("\tMa Phieu : {0}",MaPhieu);
            Console.WriteLine("\t\t\tNgay Kiem Ke : {0}",ngaythangnam.Xuat());
            Console.Write("\tNhan Vien Kiem Ke : {0}",nv.gettennv());
            Console.WriteLine("\t\tChuc Vu : {0}",nv.getChuvu());
            Console.Write("\tKiem Ke Tai Phong : {0} ",phongs.getTenPhong());
            Console.WriteLine("\t\tMa Phong : {0}", phongs.getMaPhong());
            Console.WriteLine("\tTruong Phong : {0}", phongs.getTruongPhong());
            Console.WriteLine();
            Console.WriteLine("\t{0}\t{1}\t\t{2}","TenTaiSan","SoLuong","TinhTrang");
            for (int i = 0; i < n; i++)
            {
                ts[i].Xuat();
            }
            Console.WriteLine();
            Console.Write("\tSo Tai San Da Kiem Ke: " + n);
            Console.WriteLine("\tTong So luong :" + TongSl());
        }
    }
}
