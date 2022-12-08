using System;

namespace mid_exam_3
{
    delegate double Calc_delegate(double add, double mul); //덧셈과 곱셈을 구하는 델리게이트 정의
    class Add_Mul //Add_Mul 클래스 
    {
        public double Calc_Add(double a, double b)
        {
            return a + b; //덧셈 결과 리턴
        }
        public double Calc_Mul(double a, double b)
        {
            return a * b; //곱셈 결과 리턴
        }
    }
    class Add_Mul_Test //검증용 클래스 작성
    {
        static void Main(string[] args)
        {
            Console.Write("First Input data => ");
            double a = double.Parse(Console.ReadLine()); //실수형 숫자 a 입력받음
            Console.Write("Second Input data => ");
            double b = double.Parse(Console.ReadLine()); //실수형 숫자 b 입력받음
            double add, mul; //덧셈 결과와 곱셈 결과를 저장한 변수 선언
            Add_Mul am = new Add_Mul();
            Calc_delegate cal_del_add = new Calc_delegate(am.Calc_Add);
            Calc_delegate cal_del_mul = new Calc_delegate(am.Calc_Mul);

            add = cal_del_add(a, b); //덧셈 델리게이트
            mul = cal_del_mul(a, b); //곱셈 델리게이트

            Console.WriteLine(" ADD : {0}+{1}={2}", a, b, add);
            Console.WriteLine(" MUL : {0}*{1}={2}", a, b, mul);
        }
    }
}
