using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLeader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader("kandidatai.txt"))
            {
                var kandidatai = reader.ReadLine().Split(' ');
                string laimetojas = "";
                int laimetojoKiekis = 0;
                foreach (var kandidatas in kandidatai)
                {
                    var raides = kandidatas.ToLower().ToCharArray();
                    if (UnikaliuRaidziuKiekis(raides) > laimetojoKiekis)
                    {
                        laimetojoKiekis = UnikaliuRaidziuKiekis(raides);
                        laimetojas = kandidatas;
                    }
                }

                Console.WriteLine("Laimejo: " + laimetojas);
            }
        }

        private static int UnikaliuRaidziuKiekis(char[] Raides)
        {
            int kiekis = 0;
            for (int i = 0; i < Raides.Length; i++)
            {
                bool unikali = true;
                for (int j = Raides.Length - 1; j > i; j--)
                {
                    if (Raides[i] == Raides[j])
                    {
                        unikali = false;
                        break;
                    }
                }
                if (unikali)
                {
                    kiekis++;
                }
            }
            return kiekis;
        }
    }
}