using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Tribonacci_Serisi
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 0, y = 0, z = 1, t;

            t = x + y + z;

            Console.WriteLine("TRİBONACCİ SAYILARI");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(t);
            int p = 50;

            while (p > 0)
            {
                p--;
                x = y;
                y = z;
                z = t;

                t = x + y + z;

                Console.WriteLine(t);
            }

            Console.ReadKey();
        }
    }
}
