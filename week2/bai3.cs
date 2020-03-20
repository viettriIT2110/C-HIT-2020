using System;
namespace baitap
{
    class Program
    {
        static string [] mang(string s)
        {
            return s.Split(' ');
        } 
        static void showinfo(string [] mang)
        {
            int n = mang.Length;
            string middle = "";
            for(int i =1; i<n - 2; i++)
            {
                middle += mang[i];
                middle += " ";
            }
            Console.WriteLine("Ho : " + mang[0]);
            Console.WriteLine("Ten Dem : " + middle);
            Console.WriteLine("Ten : " + mang[n-2]);
            Console.WriteLine("Nam sinh : " + mang[n-1] );
        }
        static int age(string [] mang)
        {
            return DateTime.Now.Year - int.Parse(mang[mang.Length - 1]);
        }
        static void Main(string[] args)
        {
            string s;
            Console.Write("nhap chuoi ho ten : ");
            s = Console.ReadLine();
            showinfo(mang(s));
            Console.WriteLine("so tuoi nguoi do la : " + age(mang(s)));
        }
        
    }
}
