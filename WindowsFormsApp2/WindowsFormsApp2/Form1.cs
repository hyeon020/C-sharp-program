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
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) //체크되면
                label3.TextAlign = ContentAlignment.MiddleLeft; //중앙왼쪽 정렬
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) //체크되면
                label3.TextAlign = ContentAlignment.MiddleCenter; //중앙 정렬
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) //체크되면
                label3.TextAlign = ContentAlignment.MiddleRight; //중앙오른쪽 정렬
        }
        public void Update(bool a, bool b, bool c, bool d)
        {
            FontStyle fontStyle = FontStyle.Regular;
            if (a)
                fontStyle = fontStyle | FontStyle.Bold;
            if (b)
                fontStyle = fontStyle | FontStyle.Underline;
            if (c)
                fontStyle = fontStyle | FontStyle.Italic;
            if (d)
                fontStyle = fontStyle | FontStyle.Strikeout;
            label3.Font = new Font("굴림", 9, fontStyle);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Update(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Update(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Update(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Update(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
        }
    }
}
