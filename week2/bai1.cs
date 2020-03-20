using System;
namespace baitap
{
    class Program
    {
        static void NhapSoNguyen(out int n)
        {
            n = int.Parse(Console.ReadLine());
        }
        static void NhapMang(int n, int[] mang)
        {
            for(int i= 0; i<n; i++)
            {
                Console.Write("mang [{0}]= ", i);
                mang[i] = int.Parse(Console.ReadLine());
            }
        }
        static bool KiemtraNT(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return (n > 1) ? true: false;
        }
        static void hamxuat(int n, int [] mang)
        {
            for(int i =0; i < n; i++)
            {
                if(KiemtraNT(i+1))
                    Console.Write(mang[i] + "  " );
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so nguyen n : ");
            NhapSoNguyen(out n);
            int [] mang = new int[n];
            NhapMang(n, mang);
            Console.WriteLine("Cac so o vi tri nguyen to la : ");
            hamxuat(n, mang);
        }
        
    }
}
