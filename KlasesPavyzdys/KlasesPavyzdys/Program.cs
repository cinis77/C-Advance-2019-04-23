using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesPavyzdys
{
    internal class Namas
    {
        public int Aukštai;
        public string Adresas;
        public string Tipas { get; set; }
        public string Medžiagiškumas { get; set; }

        #region Construtor field

        public Namas()
        {
        }

        public Namas(int aukstai, string adresas, string tipas, string medziagiskumas)
        {
            Aukštai = aukstai;
            Adresas = adresas;
            Tipas = tipas;
            Medžiagiškumas = medziagiskumas;
        }

        #endregion Construtor field

        public int KiekMetuJauStovi(int statybosMetai)
        {
            return DateTime.Today.Year - statybosMetai;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Namas pirmas = new Namas(); // Tuscias kontruktorius
            Namas antras = new Namas(2, "Kovo 10", "Blokinis", "Geras"); // Sukurtas netuscias konstruktorius
            Namas trecias = new Namas()
            {
                Adresas = "Kovo 10",
                Tipas = "Murinis",
                Medžiagiškumas = "Baisus",
                Aukštai = 1
            };
        }
    }
}