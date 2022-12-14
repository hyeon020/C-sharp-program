using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter10_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int xPt, yPt;
        public static readonly int MOVE = 10;
        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            this.xPt = this.button1.Location.X;
            this.yPt = this.button1.Location.Y;
            switch(e.KeyCode)
            {
                case Keys.Left:
                    xPt -= MOVE; break; //key를 왼쪽으로 눌렀을 시
                case Keys.Right:
                    xPt += MOVE; break;  //key를 오른쪽으로 눌렀을 시
                case Keys.Up:
                    yPt -= MOVE; break;  //key를 위쪽으로 눌렀을 시
                case Keys.Down:
                    yPt += MOVE; break;  //key를 쪽으로 눌렀을 시
            }
            this.button1.Text = e.KeyCode.ToString();
            this.button1.Location = new Point(xPt, yPt);
        }
    }
}
