using System;
namespace baitap
{
    class Program
    {
        static void nhapA(out Double a)
        {
            Console.Write("Nhap so thuc A bat ky : ");
            a = Double.Parse(Console.ReadLine());
        }
        static void nhapx(out Double x)
        {
            do
            {
                Console.Write("nhap x : ");
                x = Double.Parse(Console.ReadLine());
                if(x <= 0 )
                    Console.WriteLine("Nhap lại x voi x > 0 ");
            }
            while (x <= 0);
        }
        static void nhapn(out int n)
        {
            do
            {
                Console.Write("nhap n : ");
                n = int.Parse(Console.ReadLine());
                if (n <5 || n > 20)
                    Console.WriteLine("Nhap lại n voi  5 <= n <= 20 : ");
            }
            while (n < 5 || n > 20);
        }
        static Double f(Double x, int k)
        {
            return Math.Pow(Math.Sqrt(x),k);
        }
        static Double S(Double A, Double x, int n)
        {
            Double s = A;
            int k = 1;
            while(n > 0)
            {
                s += (Math.Pow(-1,k) * f(x,k++) )/ n--;
            }
            return s;
        }
        static void Main(string[] args)
        {
            Double A, x;
            int n;
            nhapA(out A);
            nhapx(out x);
            nhapn(out n);
            Console.WriteLine("gia tri ham S la : " + S(A,x,n));
        }
        
    }
}
