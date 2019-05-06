using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaiDu
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pasisveikinimas();
            Console.WriteLine("Iveskite savo varda");
            string vard = Console.ReadLine();
            Console.WriteLine("Iveskite amziu");
            int amz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite savo hobi pavadinima");
            string ho = Console.ReadLine();
            Formatavimas(vard, amz, ho);
            Formatavimas(hobi: ho, vardas: vard, amzius: amz);
        }

        /// <summary>
        /// Formatuojamas tekstas
        /// </summary>
        /// <param name="vardas"></param>
        /// <param name="amzius"></param>
        /// <param name="hobi"></param>
        public static void Formatavimas(string vardas, int amzius, string hobi)
        {
            Console.WriteLine("Jusu vardas yra: {0}, amzius ({1}m.), hobi- {2}", vardas, amzius, hobi);
        }

        public static void Pasisveikinimas()
        {
            Console.WriteLine("Sveiki,");
        }
    }
}