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

namespace _13weekdismat
{
    public partial class Form1 : Form
    {
        List<int> OT = new List<int>()    { 1, 1, 1,  1, 2,  2,  2, 3,  3, 4, 4,  4,  4,  5,  6, 6,  7, 7,  7,  8, 8,  8,  8,  9,  9,  10, 10, 10, 11, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 16, 17, 18, 19};
        List<int> DO = new List<int>()    { 2, 3, 4,  5, 3,  6,  7, 4,  7, 5, 9,  10, 11, 11, 7, 12, 8, 9,  12, 9, 12, 13, 14, 10, 14, 11, 15, 16, 16, 13, 17, 17, 18, 14, 15, 18, 20, 19, 20, 19, 18, 20, 20};
        List<int> DLINA = new List<int>() { 6, 3, 13, 5, 12, 10, 6, 20, 4, 8, 11, 4,  8,  2,  9, 15, 5, 14, 7,  8, 18, 12, 5,  1,  16, 10, 19, 3,  5,  21, 13, 6,  1,  9,  3,  6,  24, 17, 9,  9,  7,  12, 17};
        List<int> flaguzel = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        List<int> flagduga = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        List<int> N = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
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
        }
        int newotchego = 0;
        int provOT = 0;
        int provDO = 0;
        int forvivodv3 = 0;
        int boollevopravo = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            boollevopravo = 0;
            dataGridView3.RowCount = OT.Count;
            for (int i = 0; i < OT.Count; i++)
            {
                dataGridView3.Rows[i].Height = 30;
            }

            int nach = int.Parse(textBox1.Text);
            flaguzel[nach - 1] = 1;
            dataGridView1.Rows[nach - 1].Cells[1].Value = flaguzel[nach - 1].ToString();
            List<int> vetka = new List<int>();
            List<int> newNumbers = new List<int>() { nach };
            List<int> vetkaindex = new List<int>();
            int chtoto = 0;
            while (chtoto != 20)
            {
                foreach (int otchego in newNumbers)
                {
                    flaguzel[otchego - 1] = 1;
                    dataGridView1.Rows[otchego - 1].Cells[1].Value = flaguzel[otchego - 1].ToString();
                    for (int i = 0; i < OT.Count; i++)
                    {
                        if (OT[i] == otchego && flagduga[i] == 0)
                        {
                            if (flaguzel[DO[i] - 1] == 1 && flaguzel[OT[i] - 1] == 1)
                            {
                                flagduga[i] = -1;
                                dataGridView2.Rows[i].Cells[3].Value = flagduga[i].ToString();
                            }
                            else
                            {
                                vetka.Add(DLINA[i]);
                                vetkaindex.Add(i);
                                flagduga[i] = 1;
                                dataGridView2.Rows[i].Cells[3].Value = flagduga[i].ToString();
                               // newotchego = DO[i];
                                // вот ебаная ошибка
                            }
                            // найти мин знач
                            // поставить этой дуге метку 2,  УЗЛУ МЕТКУ 1   
                        }
                        else if (DO[i] == otchego && flagduga[i] == 0)
                        {
                            if (flaguzel.Contains(DO[i]) && flaguzel.Contains(OT[i]))
                            {
                                flagduga[i] = -1;
                                dataGridView2.Rows[i].Cells[3].Value = flagduga[i].ToString();
                            }
                            else
                            {
                                vetka.Add(DLINA[i]);
                                vetkaindex.Add(i);
                                flagduga[i] = 1;
                              //  newotchego = OT[i];
                            }
                        }
                    }
                }
                int min = 1000;
                int minIndex = -1;
                int indexfordelete = 0;
                for (int i = 0; i < vetka.Count; i++)
                {
                    if (vetka[i] < min)
                    {
                        min = vetka[i];
                        minIndex = vetkaindex[i];
                        indexfordelete = i;
                    }
                }
                provOT = Convert.ToInt32(dataGridView2.Rows[minIndex].Cells[0].Value);
                provDO = Convert.ToInt32(dataGridView2.Rows[minIndex].Cells[1].Value);
                if (flaguzel[provDO - 1] == 1 && flaguzel[provOT - 1] == 1)
                {
                    flagduga[minIndex] = -1;
                    dataGridView2.Rows[minIndex].Cells[3].Value = flagduga[minIndex].ToString();
                    vetka.RemoveAt(indexfordelete);
                    vetkaindex.RemoveAt(indexfordelete);
                }
                else if (flaguzel[provOT - 1] == 1)
                {
                    flagduga[minIndex] = 2;
                    dataGridView2.Rows[minIndex].Cells[3].Value = flagduga[minIndex].ToString();
                    // newotchego = 
                    //  if (vetka.Contains(provDO))
                    //  {
                    //      newotchego = provOT;
                    //  }
                    //  else if (vetka.Contains(provOT))
                    //  {
                    //      newotchego = provDO;
                    //  }
                    // if (flaguzel[provOT - 1] == 1)
                    // {
                    //
                    // }
                    newotchego = provDO;
                    newNumbers.Clear();
                    newNumbers.Add(newotchego);
                    dataGridView3.Rows[forvivodv3].Cells[0].Value = provOT.ToString();
                    dataGridView3.Rows[forvivodv3].Cells[1].Value = provDO.ToString();
                    dataGridView3.Rows[forvivodv3].Cells[2].Value = vetka[indexfordelete].ToString();
                    dataGridView3.Rows[forvivodv3].Cells[3].Value = flagduga[minIndex].ToString();
                    vetka.RemoveAt(indexfordelete);
                    vetkaindex.RemoveAt(indexfordelete);
                    forvivodv3++;
                }
                else if (flaguzel[provDO - 1] == 1)
                {
                    flagduga[minIndex] = 2;
                    dataGridView2.Rows[minIndex].Cells[3].Value = flagduga[minIndex].ToString();
                    newotchego = provOT;
                    newNumbers.Clear();
                    newNumbers.Add(newotchego);
                    dataGridView3.Rows[forvivodv3].Cells[0].Value = provOT.ToString();
                    dataGridView3.Rows[forvivodv3].Cells[1].Value = provDO.ToString();
                    dataGridView3.Rows[forvivodv3].Cells[2].Value = vetka[indexfordelete].ToString();
                    dataGridView3.Rows[forvivodv3].Cells[3].Value = flagduga[minIndex].ToString();
                    vetka.RemoveAt(indexfordelete);
                    vetkaindex.RemoveAt(indexfordelete);
                    forvivodv3++;
                }
                chtoto = 0;
                for (int i = 0; i < 20; i++)
                {
                    if (flaguzel[i] == 1)
                    {
                        chtoto++;
                    }
                }
            }
        }
    }
}
