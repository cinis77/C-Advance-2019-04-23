using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaSuSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LINESQLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lINESQLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.robotDataBaseDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'robotDataBaseDataSet.DrawingInDB' table. You can move, or remove it, as needed.
            this.drawingInDBTableAdapter.Fill(this.robotDataBaseDataSet.DrawingInDB);
            // TODO: This line of code loads data into the 'robotDataBaseDataSet.LINESQL' table. You can move, or remove it, as needed.
            this.lINESQLTableAdapter.Fill(this.robotDataBaseDataSet.LINESQL);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(' ', '_');
        }
    }
}