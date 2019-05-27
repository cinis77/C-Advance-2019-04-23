using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaiduGaudymas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Iveskite skaiciu");

                try
                {
                    int skaicius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Jusu ivestas skaicius yra: " + skaicius);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Blogas formatas");
                    System.Windows.Forms.MessageBox.Show("Test");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nenumatyta klaida: " + ex.Message);
                }
            }
        }
    }
}