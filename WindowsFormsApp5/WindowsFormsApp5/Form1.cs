using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch(listView1.FocusedItem.SubItems[0].Text)
            {
                case "메모장":
                    System.Diagnostics.Process.Start("notepad");
                    break;
                case "계산기":
                    System.Diagnostics.Process.Start("calc");
                    break;
                case "그림판":
                    System.Diagnostics.Process.Start("mspaint");
                    break;
            }
        }
    }
}
