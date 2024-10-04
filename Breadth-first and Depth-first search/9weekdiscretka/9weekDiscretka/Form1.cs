using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9weekDiscretka
{
    public partial class Form1 : Form
    {
        List<int> OT = new List<int>() {1, 1, 2, 3, 3, 4, 5, 5, 6, 8, 9, 9, 9, 10, 12 };
        List<int> DO = new List<int>() { 2, 3, 3, 4, 8, 5, 6, 8, 7, 9, 10, 11, 12, 11, 13 };
        int[] N = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = OT.Count;
            dataGridView1.ColumnCount = 2;
            for (int i = 0; i < OT.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = OT[i].ToString();
                dataGridView1.Rows[i].Cells[1].Value = DO[i].ToString();
            }
            dataGridView2.RowCount = 13;
            dataGridView2.ColumnCount = 2;
            dataGridView3.RowCount = 13;
            dataGridView3.ColumnCount = 3;
            for (int i = 0; i < 13; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridView3.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            dataGridView2.Rows[n - 1].Cells[1].Value = 1.ToString();
            int zapiska = 2;
            List<int> vetka = new List<int>();
            List<int> newNumbers = new List<int>() { n };
            List<int> uzheuse = new List<int>() { n};
            while (newNumbers.Count > 0)
            {
                foreach (int otchego in newNumbers)
                {
                    for (int i = 0; i < OT.Count; i++)
                    {
                        if (OT[i] == otchego && !uzheuse.Contains(DO[i]))
                        {
                            dataGridView2.Rows[DO[i] - 1].Cells[1].Value = zapiska.ToString();
                            vetka.Add(DO[i]);
                        }
                        else if (DO[i] == otchego && !uzheuse.Contains(OT[i]))
                        {
                            dataGridView2.Rows[OT[i] - 1].Cells[1].Value = zapiska.ToString();
                            vetka.Add(OT[i]);
                        }
                    }
                }
                newNumbers.Clear();
                foreach (int number in vetka)
                {
                    newNumbers.Add(number);
                    uzheuse.Add(number);
                }
                vetka.Clear();
                zapiska++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              int n = int.Parse(textBox2.Text);
              dataGridView3.Rows[n - 1].Cells[1].Value = 1.ToString();
              dataGridView3.Rows[n - 1].Cells[2].Value = "С неба".ToString();
              bool Pirat = false;
              int zapiska = 1;
              int otchego = n;
              int otkuda = 0;
              List<int> uzheuse = new List<int>() { n };
              List<int> nelzya = new List<int>() {  };
              List<int> dlyaproverki = new List<int>() { -10, -10, -10, -10, -10, -10, -10, -10, -10, -10, -10, -10, -10, };
              while (zapiska != 13)
              {
                  Pirat = false;
                  for (int i = 0; i < OT.Count; i++)
                  {
                      if (OT[i] == otchego && !uzheuse.Contains(DO[i]))
                      {
                          uzheuse.Add(DO[i]);
                          otkuda = otchego;
                          otchego = DO[i];
                          if (dlyaproverki[otchego - 1] == -10)
                          {
                              zapiska++;
                              dataGridView3.Rows[otchego - 1].Cells[1].Value = zapiska.ToString();
                              dlyaproverki[otchego - 1] = 1;
                              dataGridView3.Rows[otchego - 1].Cells[2].Value = otkuda.ToString();
                          }
                          Pirat = true;
                          break;
                      }
                      else if (DO[i] == otchego && !uzheuse.Contains(OT[i]))
                      {
                          uzheuse.Add(OT[i]);
                          otkuda = otchego;
                          otchego = OT[i];
                          if (dlyaproverki[otchego - 1] == -10)
                          {
                              zapiska++;
                              dataGridView3.Rows[otchego - 1].Cells[1].Value = zapiska.ToString();
                              dlyaproverki[otchego - 1] = 1;
                              dataGridView3.Rows[otchego - 1].Cells[2].Value = otkuda.ToString();
                          }
                          Pirat = true;
                          break;
                      }
                  }
                  if (Pirat == false)
                  {
                      nelzya.Add(otchego);
                      otchego = otkuda;
                      string value = dataGridView3.Rows[otchego - 1].Cells[2].Value.ToString();
                      bool isDigit = int.TryParse(value, out int number);
                      // Если значение является цифрой
                      if (isDigit)
                      {
                          otkuda = Convert.ToInt32(dataGridView3.Rows[otchego - 1].Cells[2].Value);
                      }
                  }
              }
            List<int> vetka = new List<int>() { 5, 12, 45, 23, 89, 99, 127 };
            vetka.RemoveAt(4);
            for (int i = 0; i < vetka.Count; i++)
            {
                dataGridView3.Rows[i].Cells[2].Value = vetka[i].ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            for (int i = 0; i < 13; i++)
            {
                dataGridView2.Rows[i].Cells[1].Value = "";
                dataGridView3.Rows[i].Cells[1].Value = "";
                dataGridView3.Rows[i].Cells[2].Value = "";
            }
        }
    }
}
