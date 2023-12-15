using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //линия
            Pen solidPen = new Pen(Color.Black, 3);
            g.DrawLine(solidPen, 20, 20, 100, 20);
            // штрих-пунктирная линия
            Pen dashDotPen = new Pen(Color.Black, 3);
            dashDotPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawLine(dashDotPen, 150, 20, 250, 20);
            //закрашенный прямоугольник
            SolidBrush solidBrush = new SolidBrush(Color.Yellow);
            g.FillRectangle(solidBrush, 20, 40, 80, 80);
            //прямоугольник штрих-пунктир
            Pen dashedPen = new Pen(Color.Red, 2);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawRectangle(dashedPen, 150, 40, 100, 80);
            //эллипс точками
            Pen dottedEllipsePen = new Pen(Color.Green, 4);
            dottedEllipsePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawEllipse(dottedEllipsePen, 20, 150, 90, 70);
            //заштрихованный эллипс
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.Pink, Color.White);
            g.FillEllipse(hatchBrush, 150, 150, 120, 90);
        }
    }
}
