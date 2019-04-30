using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trikampiai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            if (sk + sk1 < sk2)
            {
            }
            else if (sk1 + sk2 < sk)
            {
            }
            else if (sk + sk2 < sk1)
            {
            }
            else
            {
            }
            if (sk + sk1 > sk2 && sk1 + sk2 > sk && sk + sk2 > sk1)
            {
                Console.WriteLine("Trikampi sudaryti imanoma");
            }
            else
            {
                Console.WriteLine("Trikampio sudaryti neimanoma");
            }
        }
    }
}