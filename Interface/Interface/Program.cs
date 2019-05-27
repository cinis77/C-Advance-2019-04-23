using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacas
{
    public class PirkimoOperacija
    {
        private List<string> pirkiniai;

        private IshipementSkaiciuokle siunta;

        public PirkimoOperacija(IshipementSkaiciuokle siunta)
        {
            pirkiniai = new List<string>();
            this.siunta = siunta;
        }

        public void ĮdėtiĮkrepšelį(string prekė)
        {
            pirkiniai.Add(prekė);
        }

        public List<string> GautiPirkiniuKrepseli()
        {
            return pirkiniai;
        }

        public bool PatikrintiArPrekeYra(string preke)
        {
            return pirkiniai.Contains(preke);
        }

        public double SkaiciuotiVisaSuma()
        {
            double suma = 0;
            foreach (var item in pirkiniai)
            {
                suma++;
            }

            if (suma == 0)
            {
                throw new ArgumentNullException();
            }
            suma += siunta.SiuntosSuma(pirkiniai);

            return suma;
        }
    }

    public interface IshipementSkaiciuokle
    {
        double svorisSiuntos { get; set; }

        double SiuntosSuma();

        double SiuntosSuma(List<string> prekes);

        double SiuntosDydis(List<string> prekes);

        double SiuntosSvoris(string preke, int svoris);
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}