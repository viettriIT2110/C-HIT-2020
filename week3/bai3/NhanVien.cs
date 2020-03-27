using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class NhanVien
    {
        string Tennv, Chucvu;

        public string gettennv()
        {
            return Tennv;
        }
        public string getChuvu()
        {
            return Chucvu;
        }
        public void Nhap()
        {
            Console.Write("Nhap ten nhan vien : ");
            Tennv = Console.ReadLine();
            Console.Write("Nhap Chuc vu  : ");
            Chucvu = Console.ReadLine();
        }
    }
}
