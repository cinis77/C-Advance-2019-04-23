using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraUzduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            int pirmas = 18;
            int antras = 24;
            if (amzius > pirmas)
            {
                Console.WriteLine("Amzius yra didesnis uz pirma skaiciu");
            }
            else if (amzius > antras)
            {
                Console.WriteLine("Amzius yra didesnis uz  antra skaiciu");
            }
            else
            {
                Console.WriteLine("Amzius nera didesnis uz abu skaicius");
            }
        }
    }
}