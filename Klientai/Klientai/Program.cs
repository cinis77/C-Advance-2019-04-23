using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klientai
{
    internal class Vartotojas
    {
        public int ID { get; }
        public string Name { get; set; }

        public Adresas Adress { get; set; }

        public Shipment Siunta { get; set; }

        public readonly List<Orders> Uzsakymai;

        #region Constructor

        public Vartotojas(int ID, string vardo)
        {
            this.ID = ID;
            Name = vardo;
            Uzsakymai = new List<Orders>();
        }

        #endregion Constructor

        public virtual double SkaiciuotiKiekMoketi()
        {
            double suma = 0;
            foreach (var item in Uzsakymai)
            {
                suma += item.Kaina;
            }
            return suma;
        }
    }

    internal class Gold : Vartotojas
    {
        public DateTime ExpirationDate { get; set; }

        public Gold(int ID, string pavadinimas) : base(ID, pavadinimas)
        {
        }

        public override double SkaiciuotiKiekMoketi()
        {
            return (base.SkaiciuotiKiekMoketi() * 0.7);
        }
    }

    internal class Silver : Vartotojas
    {
        public DateTime ExpirationDate { get; set; }

        public Silver(int id, string pavadinimas) : base(id, pavadinimas)
        {
        }

        public override double SkaiciuotiKiekMoketi()
        {
            return base.SkaiciuotiKiekMoketi() * 0.9;
        }
    }

    internal class Basic : Vartotojas
    {
        public Basic(int id, string pavadinimas) : base(id, pavadinimas)
        {
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Gold goldVartotojas = new Gold(1, "Rokas");
            goldVartotojas.Uzsakymai.Add(new Orders() { ID = 1, Kaina = 20, Pavadinimas = "Raktas" });

            Silver silverVartotojas = new Silver(2, "Sima");
            silverVartotojas.Uzsakymai.Add(new Orders() { ID = 2, Kaina = 5, Pavadinimas = "Svilpukas" });

            Basic basicVartotojas = new Basic(3, "Petras");
            basicVartotojas.Uzsakymai.Add(new Orders() { ID = 3, Kaina = 10, Pavadinimas = "Nieko" });

            Vartotojas[] vartotojai = { goldVartotojas, silverVartotojas, basicVartotojas };
            foreach (var item in vartotojai)
            {
                Console.WriteLine(item.SkaiciuotiKiekMoketi());
            }
        }
    }
}