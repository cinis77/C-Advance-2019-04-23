using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestuosimGVS
{
    public partial class Pavadinimas : Form
    {
        public Pavadinimas()
        {
            InitializeComponent();
        }

        private void NespaustiMygtukas_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string path = null;
            using (OpenFileDialog ofd = new OpenFileDialog()) /// Galima naudoti kai paveldima is IDispose
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }

            Image img = Image.FromFile(path);
            Paveiksliukas.Image = img;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AntraForma form = new AntraForma();
            Controls.Add(new Button() { Location = new Point(100, 100), Size = new Size(100, 100), BackColor = Color.White });
            form.Show();
        }
    }
}