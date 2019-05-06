using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiptai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (6 - i); j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}