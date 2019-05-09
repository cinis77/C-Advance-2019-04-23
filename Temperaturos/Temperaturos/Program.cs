using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            int[] temperaturos = new int[rng.Next(2000)];
            for (int i = 0; i < temperaturos.Length; i++)
            {
                temperaturos[i] = rng.Next(-30, 30);
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            foreach (var item in temperaturos)
            {
                if (min > item)
                {
                    min = item;
                }
                if (max < item)
                {
                    max = item;
                }
                sum += item;
            }
            double vidurkis = (double)sum / temperaturos.Length;
            int sumaMaziauVidurkio = 0;
            foreach (var item in temperaturos)
            {
                if (item < vidurkis)
                {
                    sumaMaziauVidurkio += item;
                }
            }
            Console.WriteLine("Maziausia temperatura: " + min);
            Console.WriteLine("Didziausia temperatura: " + max);
            Console.WriteLine("Vidurkis: " + ((double)sum / temperaturos.Length));
            Console.WriteLine("Mazesniu uz vidurkis suma: " + sumaMaziauVidurkio);
        }
    }
}