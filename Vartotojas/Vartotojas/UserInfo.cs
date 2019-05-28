using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vartotojas
{
    public partial class UserInfo : Form
    {
        private Action ReinicializeDictionaryCallBack; // Action => void Method();
        private Action<string, int> Action; // Action<string,int> => void Method(string a, int b);

        public UserInfo(Action reinicializeDictiomaryCallBack)
        {
            InitializeComponent();
            ReinicializeDictionaryCallBack = reinicializeDictiomaryCallBack;
        }

        public UserInfo(string userName)
        {
            InitializeComponent();
            AutoSize = true;
            userNameText.Visible = false;
            PasswordText.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            RegisterB.Visible = false;
            List<string> userData = new List<string>();

            using (System.IO.StreamReader reader = new System.IO.StreamReader(@"users\" + userName + ".txt"))
            {
                userData = reader.ReadLine().Split('|').ToList();
            }

            PavardeText.Text = userData[1];
            VardasText.Text = userData[0];
            AboutText.Text = userData[2];
            pictureBox1.BackgroundImage = Image.FromFile(userData[3]);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void RegisterB_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("logIn.txt", true))
            {
                writer.WriteLine(userNameText.Text + " " + PasswordText.Text);
                writer.Flush();
            }

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"users\" + userNameText.Text + ".txt"))
            {
                writer.WriteLine(VardasText.Text + "|" + PavardeText.Text + "|" + AboutText.Text + "|" + pictureBox1.Name);
                writer.Flush();
            }
            Close();
            ReinicializeDictionaryCallBack();
            Dispose();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(ofd.FileName);
                    //pictureBox1.BackgroundImage = Properties.Resources.download;
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox1.Name = ofd.FileName;
                }
            }
        }
    }
}