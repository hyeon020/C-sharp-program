using System;

namespace exam_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("당신의 학번은 ? : ");
            String num = Console.ReadLine(); //문자열 한문장을 입력받아 num에 저장

            Console.Write("당신의 성별은(남성(m), 여성(f)) ? : ");
            String gender = Console.ReadLine(); //문자열 한문장을 입력받아 sex에 저장

            if (gender == "m") //만약 성별이 m(남성)이면
            {
                Console.WriteLine("당신은 남성이고, 학번은 {0}입니다.", num);
            }
            else //성별이 f(여성)이면
            {
                Console.WriteLine("당신은 여성이고, 학번은 {0}입니다.", num);
            }
        }
    }
}