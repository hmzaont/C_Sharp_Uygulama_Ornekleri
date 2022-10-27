using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toString
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            string a1 = a.ToString();
            string b1 = b.ToString();

            Console.WriteLine((a + b).ToString());
            Console.WriteLine(a1 + b1);

            Console.ReadKey();
        }
    }
}
