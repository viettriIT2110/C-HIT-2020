using System;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            if(a == b && b == c && c == d && d == e)
                Console.WriteLine("khong co so lon thu 2 ");
            int[] mang;
            mang = new int[5];
            mang[0] = a; mang[1] = b; mang[2] = c; mang[3] = d; mang[0] = e;
            Array.Sort(mang);
            Console.WriteLine("So long thu 2 la : " + mang[3]);
        }
    }
}
