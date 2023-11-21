using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            tmp += 1;
            if (tmp >= 60)
            {
                int minutes = Int32.Parse(txtMinutes.Text);
                minutes += 1;
                txtMinutes.Text = minutes.ToString();
                tmp = 0;
            }
            txtSeconds.Text = tmp.ToString();
            currentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
        }
    }
}
