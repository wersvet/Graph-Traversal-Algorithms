using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _11Distkratka
{
    public partial class Form1 : Form
    {
        List<int> OT = new List<int>() { 1, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 5, 6, 6, 7, 8, 8, 8, 8, 9, 10, 11, 12, 13, 13, 14};
        List<int> DO = new List<int>() { 2, 3, 4, 4, 7, 6, 9, 6, 7, 6, 7, 8, 9, 10,11,10,11,12,13,10,13, 12, 14, 14, 15, 15};
        List<int> DLINA = new List<int>() {5, 2, 9, 2, 6, 12, 5, 4, 3, 8, 3, 5, 3, 2, 12, 4, 15, 17, 7, 6, 10, 13, 5, 3, 9, 4 };
        List<int> flag = new List<int>() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        List<int> sumwalk1 = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = OT.Count;
            dataGridView1.ColumnCount = 3;
            for (int i = 0; i < OT.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = OT[i].ToString();
                dataGridView1.Rows[i].Cells[1].Value = DO[i].ToString();
                dataGridView1.Rows[i].Cells[2].Value = DLINA[i].ToString();
            }
            dataGridView2.RowCount = sumwalk1.Count;
            dataGridView2.ColumnCount = 4;
            for (int u = 0; u < sumwalk1.Count; u++)
            {
                dataGridView2.Rows[u].Cells[0].Value = (u + 1).ToString();
            }
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
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int nach = int.Parse(textBox1.Text);
            dataGridView2.Rows[nach - 1].Cells[1].Value = 0.ToString();
            flag[nach - 1] = 1;
            dataGridView2.Rows[nach - 1].Cells[3].Value = flag[nach - 1].ToString();
            int konetch = int.Parse(textBox2.Text);
            List<int> vetka = new List<int>();
            List<int> newNumbers = new List<int>() { nach };
            int chtoto = 0;
            //  while (chtoto != sumwalk1.Count)
            while (flag[konetch - 1] != 1)
            {
                foreach (int otchego in newNumbers)
                {
                    for (int i = 0; i < OT.Count; i++)
                    {
                        if (OT[i] == otchego && flag[DO[i] - 1] != 1)
                        {
                            if (dataGridView2.Rows[DO[i] - 1].Cells[2].Value == null)
                            {
                                vetka.Add(DO[i]);
                                sumwalk1[DO[i] - 1] = sumwalk1[otchego - 1] + DLINA[i];
                                dataGridView2.Rows[DO[i] - 1].Cells[1].Value = otchego.ToString();
                                dataGridView2.Rows[DO[i] - 1].Cells[2].Value = sumwalk1[DO[i] - 1].ToString();
                            }
                            else
                            {
                                int stoitdlina = Convert.ToInt32(dataGridView2.Rows[DO[i] - 1].Cells[2].Value);
                                int novayadlina = sumwalk1[otchego - 1] + DLINA[i];
                                if (stoitdlina >= novayadlina)
                                {
                                    sumwalk1[DO[i] - 1] = novayadlina;
                                    dataGridView2.Rows[DO[i] - 1].Cells[1].Value = otchego.ToString();
                                    dataGridView2.Rows[DO[i] - 1].Cells[2].Value = sumwalk1[DO[i] - 1].ToString();
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else if (DO[i] == otchego && flag[OT[i] - 1] != 1)
                        {
                            if (dataGridView2.Rows[OT[i] - 1].Cells[2].Value == null)
                            {
                                vetka.Add(OT[i]);
                                sumwalk1[OT[i] - 1] = sumwalk1[otchego - 1] + DLINA[i];
                                dataGridView2.Rows[OT[i] - 1].Cells[1].Value = otchego.ToString();
                                dataGridView2.Rows[OT[i] - 1].Cells[2].Value = sumwalk1[OT[i] - 1].ToString();
                            }
                            else
                            {
                                int stoitdlina = Convert.ToInt32(dataGridView2.Rows[OT[i] - 1].Cells[2].Value);
                                int novayadlina = sumwalk1[otchego - 1] + DLINA[i];
                                if (stoitdlina >= novayadlina)
                                {
                                    sumwalk1[OT[i] - 1] = novayadlina;
                                    dataGridView2.Rows[OT[i] - 1].Cells[1].Value = otchego.ToString();
                                    dataGridView2.Rows[OT[i] - 1].Cells[2].Value = sumwalk1[OT[i] - 1].ToString();
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
                int min = 100;
                int minIndex = 0;
                for (int i = 0; i < sumwalk1.Count; i++) // 15
                {
                    if (sumwalk1[i] != 0 && sumwalk1[i] < min && flag[i] == 0)
                    {
                        min = sumwalk1[i];
                        minIndex = i;
                    }
                    else
                    {
                        continue;
                    }
                }
                flag[minIndex] = 1;
                dataGridView2.Rows[minIndex].Cells[3].Value = flag[minIndex].ToString();
                newNumbers.Clear();
                newNumbers.Add(minIndex + 1);
                vetka.Remove(minIndex + 1);
                chtoto = 0;
                for (int i = 0; i < 15; i++)
                {
                    if (flag[i] == 1)
                    {
                        chtoto++;
                    }
                }
            }
            // konetch
            List<int> itogovpos = new List<int>() {};
            int forfinish = konetch;
            while(forfinish != 0)
            {
                itogovpos.Add(forfinish);
                dataGridView2.Rows[forfinish - 1].Cells[0].Style.BackColor = Color.Green;
                forfinish = Convert.ToInt32(dataGridView2.Rows[forfinish - 1].Cells[1].Value);
            }
            int wopi = 0;
            dataGridView3.RowCount = 1;
            dataGridView3.ColumnCount = itogovpos.Count;
            itogovpos.Reverse();
            foreach (int i in itogovpos)
            {
                dataGridView3.Rows[0].Cells[wopi].Value = i.ToString();
                dataGridView3.Columns[wopi].Width = 50;
                wopi++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = string.Empty;
            dataGridView2.RowCount = sumwalk1.Count;
            dataGridView2.ColumnCount = 4;
            for (int u = 0; u <sumwalk1.Count; u++)
            {
                dataGridView2.Rows[u].Cells[0].Value = (u + 1).ToString();
                dataGridView2.Rows[u].Cells[1].Value = "".ToString();
                dataGridView2.Rows[u].Cells[2].Value = "".ToString();
                dataGridView2.Rows[u].Cells[3].Value = "".ToString();
                dataGridView2.Rows[u].Cells[0].Style.BackColor = Color.White;
            }
            flag.Clear();
            sumwalk1.Clear();
           // vetka.Clear();
            for (int u = 0; u <sumwalk1.Count; u++)
            {
                flag.Add(0);
                sumwalk1.Add(0);
            }
        }
    }
}
