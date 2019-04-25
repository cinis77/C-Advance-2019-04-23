using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190425Pirmauzduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Vardas = "Dominykas";
            string Pavarde = "Rentelis";
            int Amzius = 26;
            float Ugis = 1.8f;
            double Svoris = 95;
            string aukstojiMokykla = "Kauno Technologijos Universitetas";
            string AkademinesGrupesKodas = "RBB15";
            int Kursas = 2;
            string StudijuProgramosPavadinimas = "Programavimas";
            int AtsiskaitytuKredituSkaicius = 60;

            Console.WriteLine("TO DO sarasas:");
            Console.WriteLine("1. Isvesti suni");
            Console.WriteLine("2. Nupirkti pieno");
            Console.WriteLine("3. Isnesti siusksles");
            Console.WriteLine("TO DO sarasas \n1.\tIsvesti suni\n2.\tNupirkti pieno\n3.\tIsnesti siuskles");
            Console.WriteLine();
            Console.WriteLine("STUDENTO DUOMENYS");
            Console.WriteLine("{0} {1} ({2}m.)", Vardas, Pavarde, Amzius);
            Console.WriteLine("Jo ugis: {0}m., svoris: {1:0.000}kg", Ugis, Svoris);
            Console.WriteLine("Jis mokosi aukstojoje mokykloje: " + aukstojiMokykla + "({0})", StudijuProgramosPavadinimas);
            Console.WriteLine("Akademine grupe kuriai priklauso yra: " + AkademinesGrupesKodas);
            Console.WriteLine("Jau yra baiges {0}, siuo metu mokosi {1} kurse", (Kursas - 1), Kursas);
            Console.WriteLine("Per studijas yra atsiskaites uz {0} kreditu", AtsiskaitytuKredituSkaicius);

            Console.WriteLine("Iveskite raide");
            char raide = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\n ivedete raide: " + raide);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Iveskite sakini: ");
            var sakinys = Console.ReadLine();
            Console.WriteLine("Jūsų ivestas sakinys: \n" + sakinys);

            Console.WriteLine("Iveksite varda");
            string var = Console.ReadLine();
            Console.WriteLine("Iveskite megiamiausios spalvos pirma raide");
            char r = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("IVeskite atsitiktini skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("IVeskite atsitiktini skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(var + " " + r + " " + sk + " " + sk1);
        }
    }
}