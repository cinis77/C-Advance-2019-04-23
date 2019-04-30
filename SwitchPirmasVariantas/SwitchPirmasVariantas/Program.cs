using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPirmasVariantas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            switch (sk)
            {
                case 1:
                    Console.WriteLine(sk + sk1 + sk2);
                    break;

                case 2:
                    Console.WriteLine(sk - sk2);
                    break;

                case 3:
                    Console.WriteLine(sk1 * sk2);
                    break;

                default:
                    Console.WriteLine("Ivesta nesamone");
                    break;
            }
        }
    }
}