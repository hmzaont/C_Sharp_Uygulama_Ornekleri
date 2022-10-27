using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumu15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            int i1, i2, t;

            Console.Write("1.Sayiyi Girin: ");
            s1=Console.ReadLine();

            Console.Write("2.Sayiyi Girin: ");
            s2 = Console.ReadLine();

            i1 = Convert.ToInt32(s1);
            i2 = Convert.ToInt32(s2);

            t = i1 + i2;

            Console.WriteLine("Toplam: " + t.ToString());

            Console.ReadKey();
        }
    }
}
