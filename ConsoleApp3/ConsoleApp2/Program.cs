using System;
class P150_8
{
    static void Main(string[] args)
    {

        for (int i = 2; i <= 9; i+= 4)    //2단부터 5단까지, 다음으로 넘어가서 6단부터 출력
        {
            for (int j = 1; j <= 9; j++)  //열 출력(1~9)
            {
                for (int k = i; k < 4 + i; k++) //몇단인지 출력
                {
                    if (k > 9)
                        break; //9단이 넘어가면 중지
                    Console.Write(k + "*" + j + "=" + k * j + "\t"); // 구구단 출력
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}