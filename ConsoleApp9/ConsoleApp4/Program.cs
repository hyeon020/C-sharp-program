using System;
using System.Threading;


namespace ConsoleApp4
{
    class SimpleThread
    {
        public void SimpleMethod() //메소드
        {
            Random randomNumber = new Random(); //랜덤 수 생성할 Random객체
            for(int i=0; i<3; i++) //3번 반복
            {
                Console.WriteLine(i + " " + Thread.CurrentThread.Name);
                Thread.Sleep(randomNumber.Next(1, 5) * 1000); //랜덤한 시간만큼 스레드 대기
            }
            Console.WriteLine("Done! " + Thread.CurrentThread.Name);
        }
    }
    class ExerciseCh6_10_4 //Chapter6 예제
    {
        public static void Main()
        {
            SimpleThread obj = new SimpleThread(); //객체 obj생성
            ThreadStart ts = new ThreadStart(obj.SimpleMethod); 
            Thread worker1 = new Thread(ts); //스레드객체 worker1 생성
            Thread worker2 = new Thread(ts); //스레드객체 worker2 생성
            worker1.Name = "Apple"; worker2.Name = "Orange";
            worker1.Start(); worker2.Start(); //스레드 실행->simpleMethod()메소드 호출
        }
    }
}
