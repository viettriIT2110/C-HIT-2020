using System;
namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("cac uoc cua n la : " );
            for(int i=1;i<=n;i++)
                if(n % i == 0)
                    Console.WriteLine(i);
                
        }
    }
}
