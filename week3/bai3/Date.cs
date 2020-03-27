using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class Date
    {
        int ngay, thang, nam;
        public void Nhap()
        {
            Console.Write("Nhap ngay : ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang : ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam : ");
            nam = int.Parse(Console.ReadLine());
        }
        public string Xuat()
        {
            string s = ngay + "/" + thang + "/" + nam;
            return s;
        }
    }
}
