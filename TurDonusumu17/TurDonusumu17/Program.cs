using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumu17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int d = (int)6.0;
            object k = "merhaba" + 15;
            float b = 10.5f;
            double c = 20.1;
            Double dd = new double();
            const double pi = 3.14;
            string[] isimler = { "Ozlem", "Nesrin", "Ozge", "Fulya" };
            object[] isim = { "Ozlem", "Nesrin", "Ozge", "Fulya" };
            string s = "true";
            string dd = "12.45f";
            b = float.Parse(dd);
            b = Convert.ToSingle(dd);
            a = Convert.ToInt32(b + c);
            bool cevap = (Convert.ToBoolean(s));
            Console.Write((float)a / d + "\n");
            Console.WriteLine("cevap=" + cevap);
            Console.WriteLine(k.GetType());
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("a={0} b={1} c={2} d={3}", a, b, c, d);
            if (isimler[0].Equals("Ozlem") == true)
                Console.WriteLine("birinci isim Ozlem");
            foreach(string ss in isimler)
            {
                Console.WriteLine(ss);
            }

            Console.ReadKey();
        }
    }
}
