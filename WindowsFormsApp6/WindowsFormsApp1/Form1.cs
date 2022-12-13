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
        Graphics g; //그래픽 객체 g
        Image img;
        Point start_point; //마우스를 누른 좌표 저장
        Point end_point; //마우스를 뗀 좌표 저장
        Point rect_start;  //확대할 범위의 사각형 왼쪽 상단 좌표
        Point rect_end;   //확대할 범위의 사각형 오른쪽 하단 좌표
        int flag = 0; //초기화면을 띄울지 확대할지 정할 flag 변수

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            g = CreateGraphics();
            img = new Bitmap("석양.jpg"); //화면에 띄울 이미지
            g.DrawImage(img, ClientRectangle);
        }

        //폼에서 마우스를 누를 시 호출되는 메소드
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
