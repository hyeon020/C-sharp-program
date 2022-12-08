using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class TSwap<T>  //제네릭 클래스 TSwap
    {
        public T x, y;  // 변수x, y 생성
        public void swap()  //T타입 변수의 값을 교환하는 swap() 메소드
        {
            T temp; //값을 보관할 변수 temp
            temp = x; x = y; y = temp;  //x, y값 교환
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TSwap<int> i = new TSwap<int>();    //int형 매개변수로 TSwap의 객체 i 생성
            i.x = 1; i.y = 2;   // x, y에 각각 1과 2저장
            Console.WriteLine("x: " + i.x + " y: " + i.y);  //현재 x, y값 출력
            i.swap();   //swap() 메소드를 호출하여 x와 y값 교환
            Console.WriteLine("x: " + i.x + " y: " + i.y);  
            TSwap<double> d = new TSwap<double>();  //double형 매개변수로 TSwap의 객체 d 생성
            d.x = 1.0; d.y = 2.0;       //d의 필드 x, y에 각각 1.0과 2.0저장
            Console.WriteLine("x: " + d.x + " y: " + d.y);  //현재 x, y값 출력
            d.swap();   //swap() 메소드를 호출하여 x와 y값 교환
            Console.WriteLine("x: " + d.x + " y: " + d.y);   //x와 y값 출력
        }
    }
}
