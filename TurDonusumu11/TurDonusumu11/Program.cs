using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumu11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 255;
            int i2 = 500;
            byte b, c;

            checked
            {
                b = (byte)i1;
                Console.WriteLine(b);

                unchecked
                {
                    c = (byte)i2;
                
                }
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }

    }
}
