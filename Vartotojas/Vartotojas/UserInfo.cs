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
        public UserInfo()
        {
            InitializeComponent();
        }

        private void RegisterB_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("logIn.txt", true))
            {
                writer.WriteLine();
                writer.WriteLine(userNameText.Text + " " + PasswordText.Text);
                writer.Flush();
            }

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"users\" + userNameText.Text + ".txt"))
            {
                writer.WriteLine(VardasText.Text + "|" + PavardeText.Text + "|" + AboutText.Text);
                writer.Flush();
            }
        }
    }
}