using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvarkingiSkaciai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            Int64 sk = Convert.ToInt64(Console.ReadLine());
            sk = Int64.MaxValue;
            Int64 atsakymas = 0;
            for (Int64 i = sk; i >= 1; i--)
            {
                if (ArTrvarkingasSkaicius(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        private static bool ArTrvarkingasSkaicius(Int64 skaiciu)
        {
            Int64 mazesnis = skaiciu % 10;
            Int64 didesnisLygus = (skaiciu / 10) % 10;
            if (didesnisLygus <= mazesnis)
            {
                if (skaiciu > 10)
                {
                    return ArTrvarkingasSkaicius((skaiciu / 10));
                }
                else
                {
                    return true;
                    //Rastas tvarkingas skaicius
                }
            }
            else
            {
                return false;
                //Netvarkingas skaicius
            }
        }
    }
}