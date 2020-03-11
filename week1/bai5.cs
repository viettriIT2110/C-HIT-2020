using System;
namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            bool check = true;
            for(int i=2;i<=Math.Sqrt(n);i++)
                if(n % i == 0)
                {
                    check = false;
                    break;
                }
            if(check && n !=1)
                Console.WriteLine("n la so nguyen to ");
            else
                Console.WriteLine("n khong phai la so nguyen to ");

        }
    }
}
