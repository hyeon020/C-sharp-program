using System;
using System.Runtime.CompilerServices;

namespace mid_exam_5
{
    interface IShape
    {
        void CalArea(); //면적
        double Radius //프로퍼티
        {
            get;
            set;
        }
        double Ar //프로퍼티
        {
            get;
        }
    }
    class Circle : IShape
    {
        public double radius; // 필드
        public double ar; // 면적 필드
                          // CalArea() 메소드 구현
                          // radius와 ar에 대한 property 구현
        public void CalArea() // interface에 없는 메소드 정의
        {
            this.ar = radius * radius * Math.PI;// Radius와 Ar 프로퍼티를 이용한 반지름과 면적을 화면 출력
        }
        public double Radius //Radius 프로퍼티
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
        public double Ar //Ar 프로퍼티
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
            Console.Write(" 원의 반지름 입력 (double 형) > ");
            double radius = double.Parse(Console.ReadLine()); //반지름 radius 입력
            IShape cir = new Circle();
            cir.Radius = radius; //입력받은 원의 반지름
            cir.CalArea(); //원의 넓이 
            Console.WriteLine(" Circle Area : radius ={0}, Area ={1}", cir.Radius, cir.Ar);
        }
    }
}
