using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Image img;
        Point start_point;
        Point end_point;
        Point rect_start;
        Point rect_end;
        int flag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            g = CreateGraphics();
            img = new Bitmap("석양.jpg");
            g.DrawImage(img, ClientRectangle);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                flag = 1;
                start_point = new Point(e.X, e.Y);
            }
            else
                flag = 0;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag == 0)
                g.DrawImage(img, ClientRectangle);
            else
            {
                end_point = new Point(e.X, e.Y);
                rect_start.X = Math.Min(start_point.X, end_point.X);
                rect_start.Y = Math.Min(start_point.Y, end_point.Y);

                rect_end.X = Math.Max(start_point.X, end_point.X);
                rect_end.Y = Math.Max(start_point.Y, end_point.Y);

                int width = rect_end.X - rect_start.X;
                int height = rect_end.Y - rect_start.Y;

                Rectangle sr = new Rectangle(rect_start.X, rect_start.Y, width, height);

                g.DrawImage(img, ClientRectangle, sr, GraphicsUnit.Pixel);
            }
        }
    }
}
