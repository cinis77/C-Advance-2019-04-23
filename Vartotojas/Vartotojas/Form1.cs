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
    public partial class LogInPage : Form
    {
        private Dictionary<string, string> Users;

        public LogInPage()
        {
            InitializeComponent();
            Users = new Dictionary<string, string>();
            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader("logIn.txt"))
                {
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var data = line.Split(' ');
                        Users.Add(data[0], data[1]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problema nuskaitinėjant failą");
            }
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            DialogResult resutl = MessageBox.Show("Do you really want to close this program?",
                "Close", MessageBoxButtons.YesNo);
            if (resutl == DialogResult.Yes)
            {
                Close();
                Dispose();
            }
        }

        private bool CheckNumber(char[] characers)
        {
            bool result = false;
            foreach (var item in characers)
            {
                if (char.IsDigit(item))
                {
                    result = true;
                }
            }
            return result;
        }

        private void LogInB_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNumber(UserName.Text.ToCharArray()))
                {
                    throw new FormatException("Šiame laukelyje negali būti skaičių");
                }

                if (CheckNumber(Password.Text.ToCharArray()) == false)
                {
                    throw new FormatException("Šiame laukelyje privalo būti skaičiai");
                }
                if (Users[UserName.Text] == Password.Text)
                {
                    MessageBox.Show("Duomenys Sutapo");
                }
                else
                {
                    MessageBox.Show("Neteisingai ivestas slaptazodis");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Reikia sukurti vartotoja");
            }
        }

        private void SingUpB_Click(object sender, EventArgs e)
        {
            UserInfo form = new UserInfo(ReinicializeDictionary);
            form.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReinicializeDictionary()
        {
            Users.Clear();
            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader("logIn.txt"))
                {
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var data = line.Split(' ');
                        Users.Add(data[0], data[1]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problema nuskaitinėjant failą");
            }
        }
    }
}