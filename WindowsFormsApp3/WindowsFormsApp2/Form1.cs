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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                fontDialog1.ShowApply = true;
            else
                fontDialog1.ShowApply = false;
            if(checkBox2.Checked )
                fontDialog1.ShowApply = true;
            else
                fontDialog1.ShowApply = false;
            fontDialog1.ShowDialog();
        }
    }
}
