using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomeniskiSkaiciai
{
    internal class Program
    {
        public static string Konvertavimas(int sk, string vienetas, string penketas, string desimt)
        {
            if (sk == 9)
            {
                return vienetas + desimt;
            }
            else if (sk == 4)
            {
                return vienetas + penketas;
            }
            else
            {
                int penki = sk / 5;
                int vienetai = sk % 5;
                string atsakymas = string.Empty;
                if (penki != 0)
                {
                    atsakymas += penketas;
                }
                for (int i = 0; i < vienetai; i++)
                {
                    atsakymas += vienetas;
                }
                return atsakymas;
            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 1000)
            {
                int simtai = skaicius / 100;
                int desimt = (skaicius / 10) % 10;
                int vnt = skaicius % 10;
                string romeniskai = Konvertavimas(simtai, "C", "D", "M")
                    + Konvertavimas(desimt, "X", "L", "C")
                    + Konvertavimas(vnt, "I", "V", "X");
                Console.WriteLine(romeniskai);
            }
            else
            {
                Console.WriteLine("M");
            }
        }
    }
}