using System;

namespace exam_02

{
    internal class Program
    {
        static void Main(String[] args)
        {
            double a, b; //실수형 a,b
            int c; //정수형 c
            double Result;  //실수형 결과 result

            Console.Write("First data(double) : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Second data(double) : ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Third data(int) : ");
            c = int.Parse(Console.ReadLine());
            if (c % 2 == 0) //c가 짝수인경우
            {
                Result = c * (a + b); 
                Console.WriteLine("First Data ={0}, Second Data ={1}, Third Data={2}, Result ={3}", a, b, c, Result);
            }
            else
            {
                Result = c / (double)(a + b);
                Console.WriteLine("First Data ={0}, Second Data ={1}, Third Data={2}, Result ={3}", a, b, c, Result);
            }
        }
    }
}
