using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilincli_tip
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1, d2; int i; byte b; char c; uint u; short s; d1 = 5.0; d2 = 4.0;
            i = (int)(d1 / d2);Console.WriteLine("Double integer'a cevrildi=" + i);Console.WriteLine();
            i = 123; b = (byte)i; Console.WriteLine("i'nin degeri=" + i + " iken b'nin degeri=" + b);
            i = 258; b = (byte)i; Console.WriteLine("i'nin degeri=" + i + " iken b'nin degeri=" + b);
            Console.WriteLine();

            u = 32146; s = (short)u;
            Console.WriteLine("u'nun degeri=" + u + " iken s'nin degeri=" + s);
            u = 35000; s = (short)u;
            Console.WriteLine("u'nun degeri=" + u + " iken s'nin degeri=" + s);
            Console.WriteLine();
            i = 90; c = (char)i; Console.WriteLine(i + " sayisini char'a donusturursek=" + c + " olur.");
            Console.ReadKey();
        }
    }
}
