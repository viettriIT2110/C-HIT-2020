using System;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());       
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                    Console.WriteLine("Day la tam giac vuong");
               
                else if (a == b && b== c)
                    Console.WriteLine("Day la tam giac deu");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Day la tam giac can");
                else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                    Console.WriteLine("Day la tam giac tu");
                else
                    Console.WriteLine("Day la tam giac nhon");
            }
            else
                Console.WriteLine("Ba canh a, b, c khong phai la ba canh cua mot tam giac ");
        
        }
    }
}
