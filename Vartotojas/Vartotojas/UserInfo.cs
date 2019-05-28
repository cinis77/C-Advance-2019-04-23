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

        private void RegisterB_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("logIn.txt", true))
            {
                writer.WriteLine(userNameText.Text + " " + PasswordText.Text);
                writer.Flush();
            }

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"users\" + userNameText.Text + ".txt"))
            {
                writer.WriteLine(VardasText.Text + "|" + PavardeText.Text + "|" + AboutText.Text);
                writer.Flush();
            }

            Close();
            ReinicializeDictionaryCallBack();
        }
    }
}