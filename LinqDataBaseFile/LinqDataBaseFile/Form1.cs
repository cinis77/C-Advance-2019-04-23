using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LinqDataBaseFile
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Func<Uzsakymai, bool>> MetoduZodynas;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Id");
            comboBox1.Items.Add("Name");
            comboBox1.Items.Add("Amount");
            comboBox1.Items.Add("DeliveryDate");
            comboBox1.Items.Add("Priority");
            comboBox1.Items.Add("State");
            comboBox1.Items.Add("AmountDone");
            comboBox1.Items.Add("OrderNumber");
            MetoduZodynas = new Dictionary<string, Func<Uzsakymai, bool>>
            {
                { "Id", x => x.Id == int.Parse(textBox1.Text) },
                { "Name", x => x.Name == textBox1.Text }
            };
        }

        private void GetTable()
        {
            DataContext db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C-Advance-2019-04-23\LinqDataBaseFile\LinqDataBaseFile\RobotDataBase.mdf;Integrated Security=True");
            var table = db.GetTable<Uzsakymai>();
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataContext db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\C-Advance-2019-04-23\LinqDataBaseFile\LinqDataBaseFile\RobotDataBase.mdf;Integrated Security=True");
                var table = db.GetTable<Uzsakymai>().Where(MetoduZodynas[(string)comboBox1.SelectedItem]).ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NepasirinktasFiltras");
            }
        }
    }
}