using System;
class P149_6
{
    public static void Main(string[] args)
    {
        int i; //반복변수
        int S; //시그마 변수
        int P; //파이 변수

        S = 0;
        for (i = 1; i <= 100; i++) //i가 1부터 100까지
            S += 2 * i; //시그마 구하는 식
        P = 1;
        for (i = 1; i <= 10; i++)
            P *= i; //파이 수열 구하는 식

        Console.WriteLine("result = {0} + {1} = {2}", S, P, S + P); // 수열의 합
    }
}
