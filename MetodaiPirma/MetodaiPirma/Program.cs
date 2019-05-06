using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaiPirma
{
    internal class Program
    {
        public static void Pasisveikinimas()
        {
            Console.WriteLine("Sveiki");
        }

        private static void Main(string[] args)
        {
            Pasisveikinimas();
            Program p = new Program();
            p.Isvedimas("Programa pradejo darba");
        }

        public void Isvedimas(string Tekstas)
        {
            Console.WriteLine(Tekstas);
        }
    }
}