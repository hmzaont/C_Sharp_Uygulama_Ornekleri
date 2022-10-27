using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turdonusum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 256;
            byte b ;
            checked
            {
                b = (byte)i;
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
