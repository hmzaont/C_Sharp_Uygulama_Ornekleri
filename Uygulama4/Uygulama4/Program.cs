using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gun, ay ve yil seklinde ayri ayri giris yapiniz:");
            int g = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int y= Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case (01):
                    Console.WriteLine(g+"."+a+"."+y+"\nOcak ayi");
                    break;
                case (02):
                    Console.WriteLine(g + "." + a + "." + y + "\nSubat ayi");
                    break;
                case (03):
                    Console.WriteLine(g + "." + a + "." + y + "\nMart ayi");
                    break;
                case (04):
                    Console.WriteLine(g + "." + a + "." + y + "\nNisan ayi");
                    break;
                case (05):
                    Console.WriteLine(g + "." + a + "." + y + "\nMayis ayı");
                    break;
                case (06):
                    Console.WriteLine(g + "." + a + "." + y + "\nHaziran ayi");
                    break;
                case (07):
                    Console.WriteLine(g + "." + a + "." + y + "\nTemmuz ayi");
                    break;
                case (08):
                    Console.WriteLine(g + "." + a + "." + y + "\nAgustos ayi");
                    break;
                case (09):
                    Console.WriteLine(g + "." + a + "." + y + "\nEylul ayi");
                    break;
                case (10):
                    Console.WriteLine(g + "." + a + "." + y + "\nEkim ayı");
                    break;
                case (11):
                    Console.WriteLine(g + "." + a + "." + y + "\nKasim ayi");
                    break;
                case (12):
                    Console.WriteLine(g + "." + a + "." + y + "\nAralik ayi");
                    break;
                default:
                    Console.WriteLine("Lutfen(01-12) aylardan birini giriniz!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
