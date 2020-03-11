using System;
namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            long s1, s2=1, s3=1;
            s1 = n * (n + 1) / 2;
            for (int i = 1; i <= n; i++)
                s2 *= i;
            for (int i = 2; i <= n; i++)
                s3 += (i - 1) * i;
            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("s3 = " + s3);

        }
    }
}
