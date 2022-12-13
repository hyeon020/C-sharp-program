﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle r;
        int sweep_angle = 300;
        int start_angle = 30;
        int count = 0;
        int feed = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            g = CreateGraphics();
            r = new Rectangle(50, 50, 100, 100);
            g.FillPie(Brushes.Yellow, r, start_angle, sweep_angle);
            g.DrawPie(Pens.Black, r, start_angle, sweep_angle);

            r = new Rectangle(90, 70, 10, 10);
            g.FillEllipse(Brushes.Black, r);
            g.DrawEllipse(Pens.Black, r);

            r = new Rectangle(feed, 90, 20, 20);
            g.FillEllipse (Brushes.Red, r);
            g.DrawEllipse(Pens.Red, r);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);

            r = new Rectangle(50, 50, 100, 100);
            g.FillPie(Brushes.Yellow, r, start_angle -15 * count, sweep_angle + 30 * count);
            g.DrawPie(Pens.Black, r, start_angle - 15 * count, sweep_angle + 30 * count);

            r = new Rectangle(90, 70, 10, 10);
            g.FillEllipse(Brushes.Black, r);
            g.DrawEllipse(Pens.Black, r);

            if(count != 2)
            {
                r = new Rectangle(feed - 30 * count, 90, 20, 20);
                g.FillEllipse(Brushes.Red, r);
                g.DrawEllipse(Pens.Red, r);
            }
            count++;
            if (count == 3)
                count = 0;
        }
    }
}
