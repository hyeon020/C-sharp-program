using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(comboBox1.Text);
            int B = int.Parse(comboBox2.Text);
            int Result;
            Result = A * B;
            textBox1.Text = Result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
