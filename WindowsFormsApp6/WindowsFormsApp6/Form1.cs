using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp6
{
    
    public partial class Form1 : Form
    {
        List<Point> list = new List<Point>(); //Point 리스트 list
        Point[] pts; //Point 배열 pts
        Graphics g;

        void Draw(bool a, bool b, bool c, bool d)
        {
            if (list.Count >= 2)
            {
                g.Clear(this.BackColor);
                if (radioButton1.Checked)
                    g.DrawLines(new Pen(Color.Black), pts);
                else if (radioButton2.Checked)
                    g.DrawPolygon(new Pen(Color.Black), pts);
                else if (radioButton3.Checked)
                    g.DrawCurve(new Pen(Color.Black), pts);
                else if (radioButton4.Checked && list.Count >= 3)
                    g.DrawClosedCurve(new Pen(Color.Black), pts);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            if(e.Button == MouseButtons.Left)
            {
                list.Add(new Point(e.X, e.Y));

                pts = new Point[list.Count];
                for(int i=0; i<list.Count; i++)
                {
                    pts[i] = list[i];
                }
                Draw(radioButton1.Checked, radioButton2.Checked, radioButton3.Checked, radioButton4.Checked);
            }
            else
            {
                g.Clear(this.BackColor);
                g.Dispose();
                list.Clear();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Draw(radioButton1.Checked, radioButton2.Checked, radioButton3.Checked, radioButton4.Checked);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Draw(radioButton1.Checked, radioButton2.Checked, radioButton3.Checked, radioButton4.Checked);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Draw(radioButton1.Checked, radioButton2.Checked, radioButton3.Checked, radioButton4.Checked);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Draw(radioButton1.Checked, radioButton2.Checked, radioButton3.Checked, radioButton4.Checked);
        }
    }
}
