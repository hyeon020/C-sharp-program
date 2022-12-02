using System;

namespace mid_exam_2
{
    class IA
    {
        public int a;
        public int b; //정수형 필드를 갖는 클래스 IA 정의
    }
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            IA class_ia = new IA();
            Console.Write("First Operand => ");
            class_ia.a = int.Parse(Console.ReadLine()) ;
            Console.Write("second Operand => ");
            class_ia.b = int.Parse(Console.ReadLine()); // a, b의 값 입력받고 class_ia객체의 a,b 필드 초기화

            result = class_sum(class_ia.a, class_ia.b); //IA 클래스를 인자로 사용
            Console.WriteLine($"a+b = {class_ia.a}+{class_ia.b}={result}");

        }
        static int class_sum(int a, int b) //IA 클래스를 인자로 사용
        {
            return a + b; //return 결과 합
        }
    }    
}
