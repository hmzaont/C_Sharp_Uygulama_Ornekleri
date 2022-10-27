using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scopes
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int x = 29;
                Console.WriteLine(x);
            }
            {
                int x = 19;
                Console.WriteLine(x);
            }
        }
    }
}

