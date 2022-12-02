using System;
class P149_5
{
    public static void Main(string[] args)
    {
        int X, Y; // 두 변수 입력
        int G; //최대공약수
        int L; //최소공배수
        int Max; //최대값 변수
        int a;

        Console.Write("첫 번째 수를 입력하세요: ");
        X = Int32.Parse(Console.ReadLine());
        Console.Write("두 번째 수를 입력하세요: ");
        Y = Int32.Parse(Console.ReadLine());

        if (X>Y) { G = X; Max = Y; }
        else { G = Y; Max = X; }

        while(true)
        {
            a = G % Max; //최대공약수 나누기 최대값 변수
            G = Max;
            Max = a;
            if (a == 0) break; //변수 r이 0, 즉 나머지가 0이면 그만
        }
        L = X * Y / G; //최소공배수는 두 변수 곱하여 최대공약수로 나누기
        Console.Write("최대공약수 = {0}, 최소공배수 = {1}", G, L);
    }
}