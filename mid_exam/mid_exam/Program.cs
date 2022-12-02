using System;

namespace mid_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, result; //입력받는 a, b값과 결과값을 실수형으로 선언
            char c; //연산자 선언
            c = char.Parse(args[0]);  
            a = float.Parse(args[1]);
            b = float.Parse(args[2]);
            if (args[0] == "*") //명령줄 인수 * 를 입력했을 때 
            {
                result = a * b; //곱하기 결과
                Console.WriteLine($"{a} {c} {b} = " + result);
            }
            else if (args[0] == "+") //명령줄 인수 + 를 입력했을 때 
            {
                result = a + b; //더하기 결과
                Console.WriteLine($"{a} {c} {b} = " + result);
            }
        }
    }
}
