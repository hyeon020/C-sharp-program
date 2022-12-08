using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(); //Form2 객체 form 생성
            if(radioButton1.Checked)  //라디오버튼1 클릭시
            {
                form.ShowDialog(); //Modal버튼이 클릭되면 모덜 방식으로 form을 띄움
            }
            if(radioButton2.Checked)  //라디오버튼2 클릭시
            {
                form.Text = "ModelessDialogBox";
                form.Show();
            }
            
        }
    }
}
