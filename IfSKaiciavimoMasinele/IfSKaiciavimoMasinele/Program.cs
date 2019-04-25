using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfSKaiciavimoMasinele
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite zenkla");
            char zenklas = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            if (zenklas == '+')
            {
                Console.WriteLine(sk + sk1);
            }
            else if (zenklas == '-')
            {
                Console.WriteLine(sk - sk1);
            }
            else if (zenklas == '*')
            {
                Console.WriteLine(sk * sk1);
            }
            else if (zenklas == '/')
            {
                Console.WriteLine((double)sk / sk1);
            }
            else
            {
                Console.WriteLine("Nesuprastas zenklas");
            }
        }
    }
}