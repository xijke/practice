using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int[] Arr = new int[10];

        private void btnNewArr_Click(object sender, EventArgs e)
        {
            ClearFields();
            int n = 10;
            int a = int.Parse(txtMin.Text);
            int b = int.Parse(txtMax.Text);
            Random r = new Random();
            for(int i=0; i<n;i++) //цикл заполнения массива рандомными числами
            {
                Arr[i] = r.Next(a, b); //заполняет массив от а до б(от мин до макс)
                lblArr.Text += Arr[i];
                if (i != n) lblArr.Text += ", ";
            }
            btnSort.Enabled = true;
        }

        private int MinNumber(int [] x, int m )
        {
            int min = x[m];
            int MinN = m;
            for(int i = m; i<x.Length; i++) //цикл для поиска мин значения в массиве
            {
                if (x[i]<min) //если следующий символ меньше текущего
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int k, t;
            for(int i=0; i < Arr.Length; i++) //цикл сортировки массива
            {
                k = MinNumber(Arr, i); //ищем минимальный символ
                t = Arr[i];
                Arr[i] = Arr[k];   //меняем текущий символ на минимальный
                Arr[k] = t;
                lblResult.Text += Arr[i];
                if(i!= Arr.Length - 1) { lblResult.Text += ", "; }
            }
            btnSort.Enabled = false;
        }

        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            btnSort.Enabled = false;
        }
    }
}
