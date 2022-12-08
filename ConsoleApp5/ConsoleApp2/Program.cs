using System;

namespace practice4_12
{
    delegate Complex D(Complex a);      //Complex a를 인자로하고 Complex를 반환하는 델리게이트D 선언
    class Complex
    {
        public double real;         //실수부
        public double image;       //허수부

        public Complex(int real)
        {
            this.real = real;
            this.image = 0;             //허수부에 0 초기화
        }

        public Complex(int real, int image)
        {
            this.real = real;           //첫번째 정수 실수부에 저장
            this.image = image;         //두번째 정수 허수부에 저장
        }

        override public String ToString()
        {
            String s = "(" + this.real + " + " + this.image + "i)";
            return s;
        }

        public static Complex operator +(Complex a, Complex b) // 덧셈 연산 메소드
        {
            Complex C = new Complex(0, 0);
            C.real = a.real + b.real;
            C.image = a.image + b.image; //c = a + b
            return C;
        }

        public static Complex operator -(Complex a, Complex b)   //뺄셈 연산 메소드
        {
            Complex C = new Complex(0, 0);
            C.real = a.real - b.real;
            C.image = a.image - b.image; //c = a - b
            return C;
        }

        public static Complex operator *(Complex a, Complex b) //곱셈 연산 메소드
        {
            Complex C = new Complex(0, 0);
            C.real = (a.real * b.real) - (a.image * b.image);
            C.image = (a.real * b.image) - (a.image * b.real); //c = a * b
            return C;
        }

        //복소수의 나눗셈 연산 메소드
        public static Complex operator /(Complex a, Complex b)
        {
            Complex C = new Complex(0, 0);
            C.real = ((a.real * b.real) + (a.image * b.image)) / (Math.Pow(b.real, 2) + Math.Pow(b.image, 2));
            C.image = ((a.image * b.real) - (a.real * b.image)) / (Math.Pow(b.real, 2) + Math.Pow(b.image, 2));
            return C;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);              //Complex 객체A 생성
            Complex b = new Complex(3, 4);              //Complex 객체B 생성

            Complex C = new Complex(0, 0);

            C = a + b;
            Console.WriteLine("덧셈결과: " + C);
            C = a - b;
            Console.WriteLine("뺄셈결과: " + C);
            C = a * b;
            Console.WriteLine("곱셈결과: " + C);
            C = a / b;
            Console.WriteLine("나눗셈결과: " + C);
        }
    }
}
