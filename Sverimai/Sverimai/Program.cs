using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sverimai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sk = 2;
            int sk1 = 2;
            int sk2 = 2;
            int sk3 = 1;
            int sk4 = 2;
            int sk5 = 2;
            int sk6 = 2;
            int sk7 = 2;
            if (sk + sk1 + sk2 < sk3 + sk4 + sk5)
            {
                if (sk < sk1)
                {
                    Console.WriteLine("Pirmas kamuoliukas brokuotas");
                }
                else if (sk > sk1)
                {
                    Console.WriteLine("Antras kamuoliukas brokuotas");
                }
                else
                {
                    Console.WriteLine("Trecias kamuoliukas brokuotas");
                }
            }
            else if (sk + sk1 + sk2 > sk3 + sk4 + sk5)
            {
                if (sk3 < sk4)
                {
                    Console.WriteLine("Ketvirtas kamuoliukas brokuotas");
                }
                else if (sk3 > sk4)
                {
                    Console.WriteLine("Penktas kamuoliukas brokuotas");
                }
                else
                {
                    Console.WriteLine("Sestas kamuoliukas brokuotas");
                }
            }
            else
            {
                if (sk6 < sk7)
                {
                    Console.WriteLine("Septinas kamuoliukas brokuotas");
                }
                else
                {
                    Console.WriteLine("Astuntas kamuoliukas brokuotas");
                }
            }
        }
    }
}