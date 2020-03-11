using System;
namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,k=2;
            Console.WriteLine("nhap x :");
            x = int.Parse(Console.ReadLine());
            Double c;
            Console.WriteLine("nhap c : " );
            c = Double.Parse(Console.ReadLine());
            Double xn = 1, gt = 1, i = 1;
            Double ex = 0;
            while ((xn / gt) >= c)
            {
                ex += xn / gt;
                xn *= x;
                gt *= i;
                i++;
            }
            ex += xn / gt;
            Console.WriteLine("e^" + x + "=" + ex);
        }
    }
}
