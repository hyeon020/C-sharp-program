using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_2
{
    interface IShape
    {
        void Area();
        double Radius
        {
            get;
            set;
        }
    }
    class Circle : IShape
    {
        public double radius;
        public double ar;
        public void Area()
        {
            this.ar = radius * radius * Math.PI; //ar는 원의 넓이
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public double Ar
        {
            get
            {
                return ar;
            }
        }
    }
    class Circle_Test
    {
        static void Main(string[] args)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("indata.dat", FileMode.Open); //파일을 열기
            }
            catch (IOException) //예외상황
            {
                Console.WriteLine("파일을 열 수 없습니다.");
                return;
            }
            StreamReader r = new StreamReader(fs);
            double d;
            d = double.Parse(r.ReadToEnd());
            Circle cir = new Circle();
            cir.Radius = d;
            cir.Area();
            Console.WriteLine("Area of Circle (r={0}) ={1}", cir.Radius, cir.Ar);
        }
    }
}

