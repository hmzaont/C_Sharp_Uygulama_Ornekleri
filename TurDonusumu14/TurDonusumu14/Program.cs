using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumu14
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;

            long l = (long)o;

            Console.WriteLine(i);
            Console.WriteLine(l);

            Console.ReadKey();
        }
    }
}
