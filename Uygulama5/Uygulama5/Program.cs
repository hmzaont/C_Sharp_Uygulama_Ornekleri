using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a degerini giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b degerini giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c degerini giriniz:");
            int c = Convert.ToInt32(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);

            if (delta > 0)
            {
                double x1 = ((-b - Math.Sqrt(delta)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Denklemin kokleri: " + x1 + " ve " + x2 + " dir.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Denklemin koku: " + x +" dir.");
            }
            else
            {
                Console.WriteLine("Reel kok yok, sanal kok vardir.");
            }
            Console.ReadKey();
        }
    }
}
