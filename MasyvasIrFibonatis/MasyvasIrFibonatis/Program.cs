using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvasIrFibonatis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] seka = new int[10];
            seka[0] = 1;
            seka[1] = 1;
            for (int i = 2; i < seka.Length; i++)
            {
                seka[i] = seka[i - 2] + seka[i - 1];
            }

            foreach (var item in seka)
            {
                Console.WriteLine(item);
            }
        }
    }
}