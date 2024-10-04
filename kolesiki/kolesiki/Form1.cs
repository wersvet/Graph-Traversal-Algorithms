using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolesiki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "1";
            dataGridView1.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "2";
            dataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "3";
            dataGridView1.Columns.Add(column3);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox6.Text))
            {
                output.Enabled = true;
            }
            else
            {
                output.Enabled = false;
            }
        }
        private void output_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int ot1 = Convert.ToInt32(textBox1.Text);
            int do1 = Convert.ToInt32(textBox2.Text);
            int ot2 = Convert.ToInt32(textBox3.Text);
            int do2 = Convert.ToInt32(textBox4.Text);
            int ot3 = Convert.ToInt32(textBox5.Text);
            int do3 = Convert.ToInt32(textBox6.Text);
            if (ot1 > do1)
            {
                int zabava = ot1;
                ot1 = do1;
                do1 = zabava;
            }
            if (ot2 > do2)
            {
                int zabava = ot2;
                ot2 = do2;
                do2 = zabava;
            }
            if (ot3 > do3)
            {
                int zabava = ot3;
                ot3 = do3;
                do3 = zabava;
            }


            for (int i = ot1; i <= do1; i++)
            {
                for (int j = ot2; j <= do2; j++)
                {
                    for (int k = ot3; k <= do3; k++)
                    {
                        dataGridView1.Rows.Add(i, j, k);
                    }
                }
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void clear_Click(object sender, System.EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }
    }
}
