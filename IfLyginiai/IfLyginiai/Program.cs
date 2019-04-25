using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfLyginiai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if ((skaicius % 2) == 0)
            {
                Console.WriteLine("Skaicius yra lyginis");
            }
        }
    }
}