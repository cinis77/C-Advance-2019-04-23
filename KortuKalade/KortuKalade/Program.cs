using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortuKalade
{
    internal class Korta
    {
        public string Tipas { get; }
        public int Pavadinimas { get; }

        public string Zenklas { get; }

        public Korta(string tipas, int pavadinimas)
        {
            Tipas = tipas;
            Pavadinimas = pavadinimas;
            Zenklas = ParinktiZenkla(pavadinimas);
        }

        private string ParinktiZenkla(int skaitineVerte)
        {
            if (skaitineVerte == 1)
            {
                return "A";
            }
            else if (skaitineVerte == 11)
            {
                return "B";
            }
            else if (skaitineVerte == 12)
            {
                return "D";
            }
            else if (skaitineVerte == 13)
            {
                return "K";
            }
            else
            {
                return skaitineVerte.ToString();
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] tipai = { "Kryžiai", "Pikai", "Širdys", "Būgnai" };
            List<Korta> kalade = new List<Korta>();
            Random rng = new Random();
            int i = 0;
            while (i < 52)
            {
                Korta korta = new Korta(tipai[rng.Next(0, tipai.Length)], rng.Next(1, 14));
                bool newKard = true;
                foreach (var item in kalade)
                {
                    if (item.Tipas == korta.Tipas && item.Pavadinimas == korta.Pavadinimas)
                    {
                        newKard = false;
                        break;
                    }
                }
                if (newKard)
                {
                    kalade.Add(korta);
                    i++;
                }
            }

            foreach (var item in kalade)
            {
                Console.WriteLine(item.Tipas + " " + item.Zenklas);
            }
        }
    }
}