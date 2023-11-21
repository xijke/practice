using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6_1
{
    public partial class Form1 : Form
    {
        private int startPosition; // Переменная для хранения начальной позиции картинки
        private bool isMoving = false; // двигается ли картинка или нет

        public Form1()
        {
            InitializeComponent();
            startPosition = pct.Left;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (pct.Right + 10 <= this.ClientSize.Width) // Проверяем, не вышел ли за правый край
            {
                pct.Left = pct.Left + 10;
            }
            else
            {
                tmr.Enabled = false; // Останавливаем таймер при достижении правого края
                isMoving = false; 
                btnStart.Text = "Start";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isMoving)
            {
                //картинка не двигается
                tmr.Enabled = false;
                isMoving = false;
                btnStart.Text = "Start";
            }
            else
            {
                //картинка двигается
                pct.Left = startPosition;
                tmr.Interval = 50;
                tmr.Enabled = true;
                isMoving = true;
                btnStart.Text = "Stop";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
