using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 13;
            int z = 42;

            if (23 == 55 && 76 > 45 && 5 < 12)
            {
                Console.WriteLine("1. ifade dogru!");
            }
            if (23 >= 23 && 45!=18)
            {
                Console.WriteLine("2. ifade dogru!");
            }
            if (x>y && z==y && z < x)
            {
                Console.WriteLine("3. ifade dogru!");
            }
            if (z > x && y<x)
            {
                Console.WriteLine("4. ifade dogru!");
            }
            if (x!=z || y<=z)
            {
                Console.WriteLine("5. ifade dogru!");
            }
            Console.ReadKey();
        }
    }
}
