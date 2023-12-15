using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart
{
    public partial class Form1 : Form
    {
        double b = 6.74;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double xMin = double.Parse(textBoxXmin.Text);
            double xMax = double.Parse(textBoxXmax.Text);
            double step = double.Parse(textBoxStep.Text);
            //количество точек графика
            int point = (int)((xMax - xMin) / step) + 1;
            //массивы значений
            double[] x = new double[point];
            double[] y1 = new double[point];
            double[] y2 = new double[point];

            for (int i = 0; i < point; i++)
            {
                x[i] = xMin + step * i;
                y1[i] = 0.8 * Math.Pow(10, -5) * Math.Pow(Math.Pow(x[i], 3) + Math.Pow(b, 3), 7.0 / 6.0);
                y2[i] = 0.5 * Math.Cos(x[i]);
            }
            //настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = xMin;
            chart1.ChartAreas[0].AxisX.Maximum = xMax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            //добавляем значения в графики
            chart1.Series[0].Points.DataBindXY(x, y2);
            chart1.Series[1].Points.DataBindXY(x, y1);
        }

    }
}