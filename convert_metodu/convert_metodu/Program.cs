using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            string d = "50";
            int b = Convert.ToInt32(a);
            double c = Convert.ToDouble(d);
            Console.WriteLine("b: " + b + "\nc: " + c);
            Console.ReadKey();
        }
    }
}
