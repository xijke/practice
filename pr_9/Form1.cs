using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountSymbols(string stroka, string symbol)
        {
            int k = 0;
            int index = 0;

            while ((index = stroka.IndexOf(symbol, index)) != -1) //цикл поиск символов строки
            {
                index += symbol.Length;
                k++;
            }

            return k;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string inputString = txtString.Text;
            int countA = CountSymbols(inputString, "а");
            int countMA = CountSymbols(inputString, "ма");

            txtKolvo.Text = countA.ToString();
            txtKolvoMa.Text = countMA.ToString();
        }
    }
}
