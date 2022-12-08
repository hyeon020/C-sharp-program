using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //버튼1 클릭했을 경우
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ShowDialog();

            FileStream fs;
            try
            {
                fs = new FileStream(openFileDialog1.FileName, FileMode.Open); //파일 열기
            }
            catch(IOException) //예외상황
            {
                Console.Write("파일을 열 수 없습니다.");
                return;
            }
            StreamReader r = new StreamReader(fs);
            string s;

            while((s = r.ReadLine()) != null ) 
            {
                textBox1.Text += s + "\r\n";
            }
            r.Close();
        }
    }
}
