using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //글자체와 글자크기를 바꿔주는 함수
        public void Font_Update()
        {
            FontStyle fontStyle = FontStyle.Regular;
            label3.Font = new Font(comboBox1.Text, (float)numericUpDown1.Value, fontStyle);
        }
        public Form1()
        {
            InitializeComponent();
        }

        //comboBox1의 값이 바뀌면 호출되는 메소드
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font_Update(); //함수 호출
        }

        //numericUpDown1의 값이 바뀌면 호출되는 메소드
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Font_Update(); //함수 호출
        }

        //textBox1의 입력이 바뀌면 호출되는 메소드
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }
    }
}
