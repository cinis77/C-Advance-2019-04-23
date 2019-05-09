using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
                if (max < a[i])
                {
                    max = a[i];
                }
            }
        }
    }
}