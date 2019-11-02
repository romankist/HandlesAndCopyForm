using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        string sourceFileName = string.Empty;
        string destFileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(sourceFileName, FileMode.Open);    //открытие для чтения
            FileStream fs2 = new FileStream(sourceFileName, FileMode.Create);    //открытие для записи

            var size = fs.Length;   //длина

            byte[] buf = new byte[1024];

            int readed = fs.Read(buf, 0, 1024); //чтение из файла (возвращает кол-во фактически прочитанных байт)

            fs2.Write(buf, 0, 10);    //запись в файл

            fs.Close();

            Thread.Sleep(100);  //усыпить поток на 100мс

            progressBar1.Value = 10;

        }

        private void button_SourceFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceFileName = openFileDialog1.FileName;
            }
        }

        private void button_DestinationFile_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                destFileName = saveFileDialog1.FileName;
            }
        }
    }
}
