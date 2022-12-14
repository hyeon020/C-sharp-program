using System;

namespace p260_8
{
    abstract class Figure
    {
        public abstract void Area();   //넓이를 구하는 메소드
        public abstract void Girth();  //둘레를 구하는 메소드
        public abstract void Draw();   //도형을 그리는 메소드
    }

    class Rectangle : Figure
    {
        public double Width { get; set; } //가로의 길이 프로퍼티
        public double Length { get; set; } //세로의 길이 프로퍼티

        public Rectangle() { Width = 1; Length = 1; }
        public Rectangle(int w, int l) { Width = w; Length = l; } //가로와 세로의 길이를 매개변수로하는 생성자

        public override void Area() //사각형의 넓이를 구하는 메소드
        {
            Console.WriteLine("사각형의 넓이: {0:F2}", Width * Length); //사각형의 넓이 = 가로*세로
        }

        public override void Girth() //사각형의 둘레를 구하는 메소드
        {
            Console.WriteLine("사각형의 둘레: {0:F2}", 2 * (Width + Length)); //사각형의 둘레 = 2*(가로+세로)
        }
        public override void Draw() //사각형을 그리는 메소드
        {
            Console.WriteLine("사각형 그리기"); //사각형 그리기라는 메시지 출력
        }
    }
    class Circle : Figure
    {
        public double Radius { get; set; } //get, set 실수형 정의
        public Circle() { Radius = 1; }
        public Circle(double radius) { Radius = radius; } //반지름을 매개변수로하는 생성자

        public override void Area()  //원의 넓이를 구하는 메소드
        {
            Console.WriteLine("원의 넓이: {0:F2}", Math.Pow(Radius, 2) * Math.PI); //원의 넓이 = 반지름*반지름*파이
        }

        public override void Girth() //원의 둘레를 구하는 메소드
        {
            Console.WriteLine("원의 둘레: {0:F2}", 2 * Math.PI * Radius); //원의 둘레 = 2*반지름*파이
        }

        public override void Draw() //원을 그리는 메소드
        {
            Console.WriteLine("원 그리기"); //원 그리기 메시지 출력
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4, 7);   //가로4, 세로7을 가지는 사각형 객체 rect 생성
            Circle cir = new Circle(4); //반지름4의 원 객체 cir 생성
            rect.Area();
            rect.Girth();
            rect.Draw();
            cir.Area();
            cir.Girth();
            cir.Draw();
        }
    }
}
