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
        public void Font_Update()
        {
            FontStyle fontStyle = FontStyle.Regular;
            label3.Font = new Font(comboBox1.Text, (float)numericUpDown1.Value, fontStyle);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font_Update();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Font_Update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }
    }
}
