using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_UnBoxing_metodu
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 120;
            object b = "Bilgisayar";
            int sayi = (int)a;
            string str = (string)b;

            Console.WriteLine("a integer'a cevrildi: " + sayi);
            Console.WriteLine("b string'e cevrildi: " + str);

            Console.ReadKey();
        }
    }
}
