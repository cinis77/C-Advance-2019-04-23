using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    internal class Automobilis
    {
        private int _Rida;
        public readonly string Markė;
        public string Gamintojas;
        private int GamybosMetai; // _GamybosMetai

        public int Rida
        {
            get
            {
                return _Rida;
            }
            set
            {
                if (value != _Rida)
                {
                    _Rida = value;
                    NuvaziuotaPerMetus();
                }
            }
        }

        public string PropertyTest { get; set; }

        public double NuvaziuotaPerMetus()
        {
            Rida = 1000;
            return (double)Rida / (DateTime.Today.Year - GamybosMetai);
        }

        public double NuvaziuotaPerMetus(double rida)
        {
            return rida / (DateTime.Today.Year - GamybosMetai);
        }

        public void GamybosMetaiSet(int GamybosMetai)
        {
            this.GamybosMetai = GamybosMetai;
        }

        public int GamybosMetaiGet()
        {
            return GamybosMetai;
        }

        public Automobilis(string marke)
        {
            Markė = marke;
        }

        public Automobilis()
        {
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Automobilis auto = new Automobilis("A6");
            Automobilis auto1 = new Automobilis("SLS");
            Automobilis auto2 = new Automobilis();
            auto.Rida = 200000;

            Console.WriteLine(auto.NuvaziuotaPerMetus());
        }
    }
}