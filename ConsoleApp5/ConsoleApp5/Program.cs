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

        public Complex AddComplex(Complex a)  // 덧셈 연산 메소드
        {
            Complex C = new Complex(0, 0);
            C.real = this.real + a.real; //실수부 덧셈
            C.image = this.image + a.image; //허수부 덧셈
            return C;
        }

        public Complex SubComplex(Complex a)   //뺄셈 연산 메소드
        {
            Complex C = new Complex(0, 0);
            C.real = this.real - a.real;
            C.image = this.image - a.image;
            return C;
        }

        public Complex MulComplex(Complex a) //곱셈 연산 메소드
        {
            Complex C = new Complex(0, 0);
            C.real = (this.real * a.real) - (this.image * a.image);
            C.image = (this.real * a.image) - (this.image * a.real);
            return C;
        }

        //복소수의 나눗셈 연산 메소드
        public Complex DivComplex(Complex a)
        {
            Complex C = new Complex(0, 0);
            C.real = ((this.real * a.real) + (this.image * a.image)) / (Math.Pow(a.real, 2) + Math.Pow(a.image, 2));
            C.image = ((this.image * a.real) - (this.real * a.image)) / (Math.Pow(a.real, 2) + Math.Pow(a.image, 2));
            return C;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);              //Complex 객체A 생성
            Complex b = new Complex(3, 4);              //Complex 객체B 생성
           
            D d = a.AddComplex;             
            Console.WriteLine("덧셈: " + d(b).ToString());
            d += a.SubComplex;              
            Console.WriteLine("뺄셈: " + d(b).ToString());
            d += a.MulComplex;              
            Console.WriteLine("곱셈: " + d(b).ToString());
            d += a.DivComplex;             
            Console.WriteLine("나눗셈: " + d(b).ToString());
        }
    }
}
