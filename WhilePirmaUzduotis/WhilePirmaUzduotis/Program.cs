using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePirmaUzduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            while (sk > 0)
            {
                Console.WriteLine(sk);
                if ((sk % 2) == 0)
                {
                    suma += sk;
                }
                sk--;
            }
            Console.WriteLine(suma);
        }
    }
}