using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            int x,y;

            Console.WriteLine("1. sayiyi giriniz:");
            s1=Console.ReadLine();

            Console.WriteLine("2. sayiyi giriniz:");
            s2 = Console.ReadLine();

            x = Convert.ToInt32(s1);
            y = Convert.ToInt32(s2);
                
            if(x>y)
            {
                if ((x % y) == 0)
            {
                Console.WriteLine("Girdiginiz sayilar birbirine tam bolunuyor!");
                
            }
                else
            {

                Console.WriteLine("Girdiginiz sayilar birbirine tam bolunmuyor!");

            }
                }
            else
            {
                if ((y % x) == 0)
                {
                    Console.WriteLine("Girdiginiz sayilar birbirine tam bolunuyor!");
                }
                else
                {
                    Console.WriteLine("Girdiginiz sayilar birbirine tam bolunmuyor!");
                }
            }
                Console.ReadKey();
            }
            
        }
        
    }