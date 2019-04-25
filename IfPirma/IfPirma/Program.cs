using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPirma
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            if (sk > sk1)
            {
                Console.WriteLine("{0} yra didesnis uz {1}", sk, sk1);
            }
            if (sk < sk1)
            {
                Console.WriteLine("{0} yra mazesnis uz {1}", sk, sk1);
            }
            if (sk == sk1)
            {
                Console.WriteLine("{0} yra lygus {1}", sk, sk1);
            }
        }
    }
}