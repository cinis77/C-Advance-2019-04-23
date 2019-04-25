using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaciuoklis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveksite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveksite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            int suma = sk + sk1;
            int skirtumas = sk - sk1;
            int sandauga = sk * sk1;
            double dalmuo = (double)sk / sk1;
            Console.WriteLine("{0} + {1} = {2}", sk, sk1, suma);
            Console.WriteLine("{0} - {1} = {2}", sk, sk1, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", sk, sk1, sandauga);
            Console.WriteLine("{0} / {1} = {2}", sk, sk1, dalmuo);
        }
    }
}