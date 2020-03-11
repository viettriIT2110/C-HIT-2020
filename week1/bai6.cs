using System;
namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k=2;
            n = int.Parse(Console.ReadLine());
            string s;
            s = Convert.ToString(n);
            s += " =  ";
            while(n > 1)
            {
                if (n % k == 0)
                {
                    s += Convert.ToString(k);
                    s += 'x';
                    n /= k;
                }
                else
                    k++;
            }
            s -= 'x';
            Console.WriteLine(s);

        }
    }
}
