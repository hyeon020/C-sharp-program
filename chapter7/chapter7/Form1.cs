using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Flat.ToString(); //flat스타일로 지정
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString(); //Popup스타일로 지정
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Standard.ToString(); //Standart스타일로 지정
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.System.ToString(); //System스타일로 
        }
    }
}
