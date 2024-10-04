using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _14weekdiskretka
{
    public partial class Form1 : Form
    {
        List<int> OT = new List<int>() { 1, 1, 1, 1, 2, 2, 2, 3, 3, 4, 4, 4, 4, 5, 6, 6, 7, 7, 7, 8, 8, 8, 8, 9, 9, 10, 10, 10, 11, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 16, 17, 18, 19 };
        List<int> DO = new List<int>() { 2, 3, 4, 5, 3, 6, 7, 4, 7, 5, 9, 10, 11, 11, 7, 12, 8, 9, 12, 9, 12, 13, 14, 10, 14, 11, 15, 16, 16, 13, 17, 17, 18, 14, 15, 18, 20, 19, 20, 19, 18, 20, 20 };
        List<int> DLINA = new List<int>() { 6, 3, 13, 5, 12, 10, 6, 20, 4, 8, 11, 4, 8, 2, 9, 15, 5, 14, 7, 8, 18, 12, 5, 1, 16, 10, 19, 3, 5, 21, 13, 6, 1, 9, 3, 6, 24, 17, 9, 9, 7, 12, 17 };
        List<int> nderevo = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        List<int> flagduga = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        List<int> N = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int trid = 0;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = N.Count;
            for (int i = 0; i < N.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = N[i].ToString();
            }
            dataGridView2.RowCount = OT.Count;

            for (int i = 0; i < OT.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = OT[i].ToString();
                dataGridView2.Rows[i].Cells[1].Value = DO[i].ToString();
                dataGridView2.Rows[i].Cells[2].Value = DLINA[i].ToString();
                dataGridView2.Rows[i].Cells[3].Value = 0.ToString();
                dataGridView2.Rows[i].Height = 15;
            }
            dataGridView3.RowCount = OT.Count;
            for (int i = 0; i < OT.Count; i++)
            {
                dataGridView3.Rows[i].Height = 30;
            }
        }
        int nomerderevo = 1;
        int wopi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int minDLINA = DLINA.Min();
            int OTmin = 0;
            int DOmin = 0;
            if (flagduga[DLINA.IndexOf(minDLINA)] == 0)
            {
                OTmin = OT[DLINA.IndexOf(minDLINA)];
                DOmin = DO[DLINA.IndexOf(minDLINA)];
                if (nderevo[OTmin - 1] == 0 && nderevo[DOmin - 1] == 0)
                {
                    nderevo[OTmin - 1] = nomerderevo;
                    nderevo[DOmin - 1] = nomerderevo;
                    nomerderevo++;

                }
                else if (nderevo[OTmin - 1] != 0 && nderevo[DOmin - 1] == 0)
                {
                    nderevo[DOmin - 1] = nderevo[OTmin - 1];
                }
                else if (nderevo[OTmin - 1] == 0 && nderevo[DOmin - 1] != 0)
                {
                    nderevo[OTmin - 1] = nderevo[DOmin - 1];
                }
                else if (nderevo[OTmin - 1] != 0 && nderevo[DOmin - 1] != 0)
                {
                    if (nderevo[OTmin - 1] < nderevo[DOmin - 1])
                    {
                        for (int i = 0; i < nderevo.Count; i++)
                        {
                            if (nderevo[i] == nderevo[DOmin - 1])
                            {
                                nderevo[i] = nderevo[OTmin - 1];
                            }
                        }
                    }
                    else if (nderevo[DOmin - 1] < nderevo[OTmin - 1])
                    {
                        for (int i = 0; i < nderevo.Count; i++)
                        {
                            if (nderevo[i] == nderevo[OTmin - 1])
                            {
                                nderevo[i] = nderevo[DOmin - 1];
                            }
                        }
                    }
                }
                else if (nderevo[OTmin - 1] == nderevo[DOmin - 1])
                {
                    
                }
                dataGridView3.Rows[wopi].Cells[2].Value = minDLINA.ToString();
                dataGridView3.Rows[wopi].Cells[0].Value = OTmin.ToString();
                dataGridView3.Rows[wopi].Cells[1].Value = DOmin.ToString();
                flagduga[DLINA.IndexOf(minDLINA)] = 2;
                dataGridView3.Rows[wopi].Cells[3].Value = flagduga[DLINA.IndexOf(minDLINA)].ToString();

                dataGridView1.Rows[OTmin - 1].Cells[1].Value = nderevo[OTmin - 1].ToString();
                dataGridView1.Rows[DOmin - 1].Cells[1].Value = nderevo[DOmin - 1].ToString();

                dataGridView2.Rows[DLINA.IndexOf(minDLINA)].Cells[3].Value = flagduga[DLINA.IndexOf(minDLINA)].ToString();

                DLINA[DLINA.IndexOf(minDLINA)] = 100;
                wopi++;
                trid++;
            }

            if (trid == 31)
            {
                dataGridView1.Rows[18 - 1].Cells[1].Value = 1.ToString();
            }




            int provkon = 0;
            for (int u = 0; u<20; u++)
            {
                if (nderevo[u] == 1)
                {
                    provkon++;
                }
            }
            if (provkon == 20)
            {
                MessageBox.Show("ВСЕ");
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
        public void Sorting()
        {
            int n = DLINA.Count;
            for (int i = 1; i < n; ++i)
            {
                int keyDLINA = DLINA[i];
                int keyOT = OT[i];
                int keyDO = DO[i];
                int j = i - 1;

                while (j >= 0 && DLINA[j] > keyDLINA)
                {
                    DLINA[j + 1] = DLINA[j];
                    OT[j + 1] = OT[j];
                    DO[j + 1] = DO[j];
                    j = j - 1;
                }
                DLINA[j + 1] = keyDLINA;
                OT[j + 1] = keyOT;
                DO[j + 1] = keyDO;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sorting();
            for (int i = 0; i < OT.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = OT[i].ToString();
                dataGridView2.Rows[i].Cells[1].Value = DO[i].ToString();
                dataGridView2.Rows[i].Cells[2].Value = DLINA[i].ToString();
                dataGridView2.Rows[i].Cells[3].Value = 0.ToString();
                dataGridView2.Rows[i].Height = 15;
            }
        }
    }
}
