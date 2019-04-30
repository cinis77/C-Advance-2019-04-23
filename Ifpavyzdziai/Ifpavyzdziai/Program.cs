using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifpavyzdziai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int pirmas = 20;
            int antras = 10;
            int trecias = 5;

            string something = null;
            string a = something != null ? "A" : "B";

            if (pirmas > antras && pirmas < 100)
            {
                Console.WriteLine("Pirma salyga yra tenkinama");
            }
            else if (antras > 0 && antras > pirmas)
            {
                Console.WriteLine("Antra salyga yra tenkinama");
            }
            else if (pirmas > antras && pirmas > trecias || pirmas > 0)
            {
                Console.WriteLine("Tenkinama trecia salyga");
            }
            else if (trecias >= 5 && trecias <= 10 || trecias > pirmas || trecias > antras)
            {
                Console.WriteLine("Ketvirta salyga yra tenkinama");
            }
        }
    }
}