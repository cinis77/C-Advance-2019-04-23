using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto
{
    public partial class Teleloto : Form
    {
        public Teleloto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mygtuko paspaudimo ivykis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generuo_Click(object sender, EventArgs e)
        {
            TextBox[] melyniLangeliai = { M1, M2, M3, M4, M5 };
            TextBox[] juodiLangeliai = { J1, J2, J3, J4, J5 };
            TextBox[] raudoniLangeliai = { R1, R2, R3, R4, R5 };
            TextBox[] geltoniLangeliai = { G1, G2, G3, G4, G5 };
            TextBox[] zaliLAngeliai = { Z1, Z2, Z3, Z4, Z5 };
            GeneruotiKamuoliukus(melyniLangeliai, 1, 16);
            GeneruotiKamuoliukus(juodiLangeliai, 16, 31);
            GeneruotiKamuoliukus(raudoniLangeliai, 31, 46);
            GeneruotiKamuoliukus(geltoniLangeliai, 46, 61);
            GeneruotiKamuoliukus(zaliLAngeliai, 61, 76);
        }

        private void GeneruotiKamuoliukus(TextBox[] laukeliai, int a, int b)
        {
            Random rng = new Random();
            int i = 0;
            while (i < laukeliai.Length)
            {
                int kamuoliukas = rng.Next(a, b);
                bool nevienodas = true;
                foreach (var item in laukeliai)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        continue;
                    }
                    if (kamuoliukas == int.Parse(item.Text))
                    {
                        nevienodas = false;
                        break;
                    }
                }
                if (nevienodas)
                {
                    laukeliai[i].Text = kamuoliukas.ToString();
                    i++;
                }
            }
        }

        private void Zaisti_Click(object sender, EventArgs e)
        {
            List<int> istrauktiKamuoliukai = new List<int>();
            int i = 0;
            Random rng = new Random();
            while (i < 47)
            {
                int kamuoliukas = rng.Next(1, 76);
                bool nevienodas = true;
                foreach (var item in istrauktiKamuoliukai)
                {
                    if (item == kamuoliukas)
                    {
                        nevienodas = false;
                        break;
                    }
                }
                if (nevienodas)
                {
                    istrauktiKamuoliukai.Add(kamuoliukas);
                    Isridenti.Text += kamuoliukas + " ";
                    i++;
                    TikrintiBilieta(kamuoliukas);
                }
            }
        }

        private void TikrintiBilieta(int kamuoliukas)
        {
            TextBox[] visiKamuoliukai =
                {
                M1, M2, M3, M4, M5 ,
                J1, J2, J3, J4, J5,
                R1, R2, R3, R4, R5,
                G1, G2, G3, G4, G5,
                Z1, Z2, Z3, Z4, Z5
            };
            foreach (var item in visiKamuoliukai)
            {
                if (item.Text == kamuoliukas.ToString())
                {
                    item.BackColor = Color.Green;
                }
            }
        }
    }
}