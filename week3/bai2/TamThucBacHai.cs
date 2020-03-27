using System;
using System.Collections.Generic;
using System.Text;

namespace baitap
{
    class TamThucBacHai
    {
        Double a, b, c;
        public TamThucBacHai() { }
        public TamThucBacHai(Double a, Double b, Double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Fx()
        {
            char daub, dauc;
            daub = (b <= 0) ? ' ' : '+';
            dauc = (c <= 0) ? ' ' : '+';
            Console.WriteLine("F(x) = {0}*x^2 {3}{1}*x {4}{2}",a,b,c,daub,dauc);
        }
        public static TamThucBacHai operator -(TamThucBacHai f)
        {
            TamThucBacHai temp = new TamThucBacHai
            {
                a = -f.a,
                b = -f.b,
                c = -f.c,
            };
            return temp;
        }
        public static TamThucBacHai operator +(TamThucBacHai f1,TamThucBacHai f2)
        {
            TamThucBacHai temp = new TamThucBacHai
            {
                a = f1.a + f2.a,
                b = f1.b + f2.b,
                c = f1.c + f2.c,
            };
            return temp;
        }
        public static TamThucBacHai operator -(TamThucBacHai f1, TamThucBacHai f2)
        {
            TamThucBacHai temp = new TamThucBacHai
            {
                a = f1.a - f2.a,
                b = f1.b - f2.b,
                c = f1.c - f2.c,
            };
            return temp;
        }
    }
}
