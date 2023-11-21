using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pr7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst.Items.Add(txt.Text);
            txt.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            if (File.Exists(fileName)) //существует ли файл
            {
                File.Delete(fileName); 
            }
            using(FileStream fs = File.Create(fileName, 1024)) //(файловый поток) создание файла
            using(BinaryWriter bw = new BinaryWriter(fs)) //для записи бинарных данных
            {
                for (var i = 0; i < lst.Items.Count; i++) //цикл для сохранения строк в файле
                {
                    bw.Write(lst.Items[i].ToString()); //запись каждой строки в бф
                }
                bw.Close();
                fs.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text; //чтение из "Путь к файлу"
            lstFromfile.Items.Clear();
            using(FileStream fs = new FileStream(fileName, FileMode.Open)) //открытие файла
            using(BinaryReader br = new BinaryReader(fs)) //чтение бинарных данных
            {
                while (br.PeekChar()!=-1) //проверка наличия символов в файле
                {
                    lstFromfile.Items.Add(br.ReadString()); 
                }
                br.Close();
                fs.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
