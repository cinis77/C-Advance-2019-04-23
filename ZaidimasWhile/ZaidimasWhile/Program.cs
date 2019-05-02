using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaidimasWhile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int min = 1;
            int max = 3000;
            Console.WriteLine("Sugalvokite skaiciu nuo 1 iki 3000");
            Console.WriteLine("Sugalvojus skaiciu spausti enter");
            Console.ReadLine();
            Console.WriteLine("Iveskite daugiau maziau arba atspejai");
            Console.WriteLine("Speju skaiciu: " + ((min + max) / 2));
            string atsakymas = Console.ReadLine();
            while (atsakymas.ToLower() != "atspejai")
            {
                if (atsakymas.ToLower() == "daugiau")
                {
                    min = (min + max) / 2;
                }
                else if (atsakymas.ToLower() == "maziau")
                {
                    max = (min + max) / 2;
                }
                Console.WriteLine("Speju skaiciu: " + ((min + max) / 2));
                Console.WriteLine("Iveskite daugiau maziau arba atspejai");
                atsakymas = Console.ReadLine();
            }
            Console.WriteLine("Atspejau!!!!!");
        }
    }
}