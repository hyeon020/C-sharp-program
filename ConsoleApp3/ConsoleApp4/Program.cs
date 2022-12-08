using System;
class P150_10
{
    public static void Main(string[] args)
    {
        int[] don = { 500, 100, 50, 10, 5, 1 }; //동전 금액
        int[] change = new int[6];
        int pay = 1000; //지불한 돈
        int price; //제품가격의 변수
        int sum; //동전 개수의 합
        int i;

        while(true)
        {
            Console.Write("물건의 가격을 입력하세요.: ");
            price = Int32.Parse(Console.ReadLine());
            if (price >= 1 && price < 1000) break; //가격은 1원에서 1000원 사이
            Console.WriteLine("물건의 가격은 1000원을 넘을 수 없습니다.");
            return;
        }

        pay -= price; //지불한 가격에서 가격을 뺌
        sum = 0;
        for(i=0; i<6; i++) //배열 0부터 6까지
        {
            change[i] = pay / don[i];
            sum += change[i];
            pay %= don[i]; //거스름돈 최소 동전 개수를 구함
            if (pay == 0) break;
        }
        for (i = 0; i < 6; i++)
            Console.WriteLine("{0}원: {1}개", don[i], change[i]); //동전의 개수를 출력
        Console.WriteLine("거스름돈의 최소 동전 개수: {0}개\n",sum);
    }
}
