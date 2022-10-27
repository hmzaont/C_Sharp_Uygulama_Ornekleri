using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 48 / 6 / 4;
            int b = 24 / 3 * 2;
            double c = Math.Pow(2,2) + 5 - 1 + 4;
            int d = (7 + 4) * 2 - 1 + 8 / 2;
            double e = (5 - 1) * 2 - 1 + Math.Pow(7,2) / 2;

            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e);
            Console.ReadKey();
        }
    }
}
