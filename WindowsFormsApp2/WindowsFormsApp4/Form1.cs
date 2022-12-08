using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //버튼 기반 컨트롤 클릭 시
            listBox1.Items.Clear(); //리스트 상자 모든 항목 제거
            listBox1.Items.Add("버튼"); //"버튼" 항목 추가
            listBox1.Items.Add("체크 상자"); //"체크 상자" 항목 추가
            listBox1.Items.Add("라디오 버튼"); // "라디오 버튼" 항목 추가
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //리스트 기반 컨트롤 클릭 시
            listBox1.Items.Clear(); //리스트 상자 모든 항목 제거
            listBox1.Items.Add("리스트 상자"); //"리스트 상자" 항목 추가
            listBox1.Items.Add("콤보 상자"); // "콤보 상자" 항목 추가
            listBox1.Items.Add("체크 리스트 상자"); // "체크 리스트 상자" 항목 추가
        }
    }
}
