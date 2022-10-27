using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6
{
    class Program
    {
        static void Main(string[] args)
        {
            int derece, radyan, grad;

            Console.WriteLine("Derece degerini giriniz:");
            derece = Convert.ToInt32(Console.ReadLine());

            radyan = Convert.ToInt32(derece * Math.PI / 180);
            grad = derece * 200 / 180;

            Console.WriteLine("Radyan degeri: " + radyan + "\nGrad degeri: " + grad);
            Console.ReadKey();
        }
    }
}
