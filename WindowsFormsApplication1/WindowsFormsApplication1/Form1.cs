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

        /*
        string sourceFileName = string.Empty;
        string destFileName = string.Empty;
        */
        //for quick test
        string sourceFileName = "Z:\\os\\lab3\\testsource\\privet.txt";
        string destFileName = "Z:\\os\\lab3\\testdest\\poka.txt";
        //
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(sourceFileName, FileMode.Open);    //открытие для чтения
            FileStream fs2 = new FileStream(destFileName, FileMode.Create);    //открытие для записи

            var size = fs.Length;   //длина

            byte[] buf = new byte[1024];
                        
            while (fs.Position<fs.Length){
                int readed = fs.Read(buf, 0, 1024); //чтение из файла (возвращает кол-во фактически прочитанных байт)
                progressBar1.Value = ((int)fs.Position) / (int)fs.Length * 100;
                //fs2.Write(buf, 0, 10);    //запись в файл
                fs2.Write(buf, 0, readed);
                Thread.Sleep(100);
            }
            fs.Close();
            fs2.Close();

            Thread.Sleep(100);  //усыпить поток на 100мс

            progressBar1.Value = 100;

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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox_SourceFile.Text = sourceFileName;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox_DestinationFile.Text = destFileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
