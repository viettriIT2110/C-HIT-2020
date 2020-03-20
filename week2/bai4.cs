using System;
namespace baitap
{
    class Program
    {
        struct Date
        {
            public int Day;
            public int Month;
            public int Year;
        }
        struct SinhVien
        {
            public string ID, name;
            public Date DateOfBirth;
        }
        static void Input(ref SinhVien sv)
        {
            Console.Write("Nhap Id : ");
            sv.ID = Console.ReadLine();
            Console.Write("Nhap Name : ");
            sv.name = Console.ReadLine();
            Console.Write("Nhap ngay sinh : ");
            sv.DateOfBirth.Day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang sinh : ");
            sv.DateOfBirth.Month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam sinh : ");
            sv.DateOfBirth.Year = int.Parse(Console.ReadLine());
        }
        static void Output(SinhVien sv)
        {
            Console.Write("\t" + sv.ID + "\t" + sv.name);
            Console.WriteLine("\t" + sv.DateOfBirth.Day +'/' + sv.DateOfBirth.Month + '/' + sv.DateOfBirth.Year );
        }
        static void Inputsv(SinhVien [] sv, int n)
        {
            for(int i= 0; i < n; i++)
            {
                Console.WriteLine("\t\t\tNhap sv thu {0} " , i+1 );
                Input(ref sv[i]);
            }
        }
        static void Outputsv(SinhVien[] sv, int n)
        {
            Console.Write("\tstt");
            Console.Write("\tId");
            Console.Write("\t\tName");
            Console.WriteLine("\t\tDate");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t{0}",i+1);
                Output(sv[i]);
            }
        }
        static void Swap(ref SinhVien sv1, ref SinhVien sv2)
        {
            SinhVien temp = sv1;
            sv1 = sv2;
            sv2 = temp;
        }
        static void SortByYearOfBirth(SinhVien[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (sv[j - 1].DateOfBirth.Year > sv[j].DateOfBirth.Year)
                    {
                        Swap(ref sv[j - 1], ref sv[j]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap n sv : ");
            n = int.Parse(Console.ReadLine());
            SinhVien [] sv = new SinhVien[n];
            Inputsv(sv, n);
            Outputsv(sv, n);
            SortByYearOfBirth(sv, n);
            Console.WriteLine("\t\tDanh Sach sv sau khi sap xep lai la ");
            Outputsv(sv, n);
        }
        
    }
}
