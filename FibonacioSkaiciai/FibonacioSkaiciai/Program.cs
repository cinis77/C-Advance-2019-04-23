using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacioSkaiciai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int skaicius1 = 1;
            int skaicius2 = 1;
            Console.WriteLine("Iveskite kiek norite matyti fibonacio skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skaicius1);
            Console.WriteLine(skaicius2);
            for (int i = 2; i < n; i++)
            {
                int skaicius3 = skaicius1 + skaicius2;
                Console.WriteLine(skaicius3);
                skaicius1 = skaicius2;
                skaicius2 = skaicius3;
            }
        }
    }
}