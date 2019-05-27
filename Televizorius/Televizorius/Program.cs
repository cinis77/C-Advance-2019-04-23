using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televizorius
{
    internal interface ITelevizijosRysis
    {
        void GautiRysis();

        void JungimosiTipas();
    }

    internal class PalydovineTelevizija : ITelevizijosRysis
    {
        public void GautiRysis()
        {
            Console.WriteLine("Gaunamas palydovinis signalas");
        }

        public void JungimosiTipas()
        {
            Console.WriteLine("HDMI kabelis");
        }
    }

    internal class AntzemineTelevizija : ITelevizijosRysis
    {
        public void GautiRysis()
        {
            Console.WriteLine("Gaunamas antzeminis signalas");
        }

        public void JungimosiTipas()
        {
            Console.WriteLine("Antenos kabelis");
        }
    }

    internal class InternetineTelevizija : ITelevizijosRysis
    {
        public void GautiRysis()
        {
            Console.WriteLine("Gaunamas internetinis signalas");
        }

        public void JungimosiTipas()
        {
            Console.WriteLine("Wifi");
        }
    }

    internal class Televizorius
    {
        private ITelevizijosRysis Rysys;

        public Televizorius(ITelevizijosRysis rysys)
        {
            Rysys = rysys;
        }

        public void RodytiTelevizija()
        {
            Rysys.GautiRysis();
            Rysys.JungimosiTipas();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            PalydovineTelevizija palydovine = new PalydovineTelevizija();
            Televizorius telikas = new Televizorius(palydovine);
            telikas.RodytiTelevizija();
            InternetineTelevizija internetine = new InternetineTelevizija();
            telikas = new Televizorius(internetine);
            telikas.RodytiTelevizija();
        }
    }
}