using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6_2
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int counter = 1;
            double sum = 0.0;
            double summand;
            double x;
            double precision;

            if (double.TryParse(txtX.Text, out x)) //удалось ли преобразовать значение в x
            {
                
                if (double.TryParse(txtPrecision.Text, out precision)) //удалось ли преобразовать значение в precision
                {
                    do //цикл для вычисления 
                    {
                        summand = x / counter;
                        sum += summand;
                        counter++;
                    } while (Math.Abs(summand) > precision);

                    lblResult.Text = "sum= " + sum.ToString() + ", quantity= " + (counter -1).ToString();
                }
                
                else
                {
                    lblResult.Text = "Введите числа через запятую в precision!";
                }
            }

            else
            {
                lblResult.Text = "Введите числа через запятую в x!";
            }
        }
    }
}
