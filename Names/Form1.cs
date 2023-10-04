using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
            Cursor.Position = PointToScreen(justBtn.Location);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >=48 && e.KeyChar <=57)
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");
                switch(e.KeyChar) 
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed.");
                        e.Handled = true;
                        break;

                }
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(btnAdd.Location);
            justBtn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            button1.Text = "Print && Close";
            label2.Text = "&Print";
            label2.TabIndex = 9;
            button1.TabIndex = 10;

        }
    }
}
