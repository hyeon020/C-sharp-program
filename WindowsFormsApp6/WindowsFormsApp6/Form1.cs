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
        Graphics g; //그래픽 객체 g

        void Draw(bool a, bool b, bool c, bool d)
        {
            if (list.Count >= 2)
            {
                g.Clear(this.BackColor); //이전 내용 지우기
                if (radioButton1.Checked) //Line이 체크 되어 있을 경우
                    g.DrawLines(new Pen(Color.Black), pts);
                else if (radioButton2.Checked) //Polygon이 체크 되어 있을 경우
                    g.DrawPolygon(new Pen(Color.Black), pts);
                else if (radioButton3.Checked) //Curve가 체크 되어 있을 경우
                    g.DrawCurve(new Pen(Color.Black), pts);
                //ClosedCurve가 체크 되어 있을 경우, Point가 3개 이상 저장 되어 있으면
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
            if(e.Button == MouseButtons.Left) //마우스 왼쪽 버튼 클릭 시
            {
                list.Add(new Point(e.X, e.Y)); //리스트에 마우스 클릭 좌표 추가 

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
            //라디오버튼 체크 상태에 따른 그리기
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
