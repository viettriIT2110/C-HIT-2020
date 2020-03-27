using System;
using baitap;
namespace baitap
{
    class Program
    {
        static void NhapHH(int n, HangHoa[] hh)
        {
            Console.WriteLine("\t\t Nhap Danh Sach Hang Hoa");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\tNhap hang hoa thu {0}",i+1);
                hh[i] = new HangHoa();
                hh[i].Nhap();
            }
        }
        static void XuatHH(int n, HangHoa[] hh)
        {
            Console.WriteLine("\t\tDanh Sach Hang Hoa");
            Console.WriteLine("\t\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}","MaHang", "TenHang", "DonGia", "SoLuong", "ThanhTien");
            for (int i = 0; i < n; i++)
            {
                hh[i].Xuat();
            }
        }
        static void SapXep(int n,HangHoa [] hh)
        {
            for (int i = 0; i< n-1; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (hh[j - 1].ThanhTien() > hh[j].ThanhTien())
                    {
                        HangHoa t = hh[j - 1];
                        hh[j - 1] = hh[j];
                        hh[j] = t;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n hang hoa : ");
            n = int.Parse(Console.ReadLine());
            HangHoa[] hh = new HangHoa[n];
            NhapHH(n, hh);
            SapXep(n, hh);
            XuatHH(n, hh);
            Console.ReadKey();
        }
        
    }
}
