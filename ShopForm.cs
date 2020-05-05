using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();

            InitializeMenuGridColumns();
        }

        private void InitializeMenuGridColumns()
        {
            DataGridViewColumn col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Име";
            col.DataPropertyName = "Name";
            col.ReadOnly = true;
            gvMenu.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Цена";
            col.DataPropertyName = "Price";
            col.ReadOnly = true;
            gvMenu.Columns.Add(col);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
