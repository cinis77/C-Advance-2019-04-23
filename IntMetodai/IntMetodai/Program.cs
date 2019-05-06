using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntMetodai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaicius");
            var sk = Convert.ToInt32(Console.ReadLine());
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out sk))
            {
            }

            Console.WriteLine(Suma(sk, sk1));
            Console.WriteLine(Skirtumas(sk, sk1));
            Console.WriteLine(Sandauga(sk, sk1));
            Console.WriteLine(Dalyba(sk, sk1));
        }

        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int Skirtumas(int a, int b)
        {
            return (a - b);
        }

        public static int Sandauga(int a, int b)
        {
            return (a * b);
        }

        public static double Dalyba(int a, int b)
        {
            return (double)a / b;
        }
    }
}