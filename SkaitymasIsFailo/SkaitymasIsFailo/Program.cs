using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SkaitymasIsFailo
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            string path = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text file(.csv)|*.csv";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}