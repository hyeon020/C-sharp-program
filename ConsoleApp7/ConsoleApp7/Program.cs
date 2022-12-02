using System;

namespace p259_7
{
    class Temperature
    {
        double degree;
        public Temperature(double degree)   //생성자
        {
            this.degree = degree;
        }
        public double Degree        //프로퍼티
        {
            get { return degree; }
        }
    }
    class Celsius : Temperature //클래스 Celsius
    {
        public Celsius(double t) : base(t) { }

        public static explicit operator Celsius(double d) //(1).double을 Celsius로 변환하는 형변환 연산자
        {
            Celsius c = new Celsius(d);
            return c;
        }

        public static explicit operator Celsius(Fahrenheit f) //(2).Fahrenheit을 Celsius로 변환하는 형변환 연산자
        {
            Celsius c = (Celsius)((f.Degree - 32.0) * 5 / 9);
            return c;
        }

        public static explicit operator double(Celsius c) //(3).Celsius를 double로 변환하는 형변환 연산자
        {
            return c.Degree;
        }
    }
    class Fahrenheit : Temperature  //클래스 Fahrenheit
    {
        public Fahrenheit(double t) : base(t) { }

        public static explicit operator Fahrenheit(double d) //(!).double을 Fahrenheit로 변환하는 형변환 연산자
        {
            Fahrenheit f = new Fahrenheit(d);
            return f;
        }

        public static explicit operator Fahrenheit(Celsius c)  //(2).Celsius를 Fahrenheit로 변환하는 형변환 연산자
        {
            Fahrenheit f = (Fahrenheit)((c.Degree * 9 / 5 + 32));
            return f;
        }

        public static explicit operator double(Fahrenheit f)  //(3).Fahrenheit을 double로 변환하는 형변환 연산자
        {
            return f.Degree;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double d = 100;                //double형 d에 100 저장
            Celsius c = (Celsius)d;         //double형 d를 Clsius로 형변환하여 c에저장
            Console.WriteLine("섭씨 " + d + "도: " + c.Degree);    
            Fahrenheit f = (Fahrenheit)c;   //Celsius형 c를 Fahrenheit로 형변환하여 f에저장
            Console.WriteLine("섭씨 " + d + "도를 화씨로 변환: " + f.Degree);   

            Fahrenheit f2 = (Fahrenheit)d;   //double형 d를 Fahrenheit로 형변환하여 f2에저장
            Console.WriteLine("화씨 " + d + "도: " + f2.Degree);    
            Celsius c2 = (Celsius)f2;         //Fahrenheit형 f2를 Celsius로 형변환하여 c2에저장
            Console.WriteLine("화씨 " + d + "도를 섭씨로 변환: " + c2.Degree);    
        }
    }
}

