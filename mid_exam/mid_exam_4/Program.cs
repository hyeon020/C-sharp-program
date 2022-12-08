using System;

namespace mid_exam_4
{
    public delegate void EventHandler(int k); //이벤트를 위한 델리게이트 정의
    class Button
    {
        int a; //입력받을 정수 a 
        public event EventHandler Push; //이벤트 선언

        public void OnPush()
        {
            Console.Write(" Enter integer input (10 이하 정수 입력) => ");
            int a = int.Parse(Console.ReadLine());
            if (Push != null)
                Push(a); //이벤트 발생

        }
    }
    class EventHandlerClass //EventHandler 클래스
    {
       public void MyMethod(int k)
       {
            for(int i=0;i<=k;i++) //i는 0부터 k까지
            {
                Console.Write("i= {0}, ", i); //for문을 사용하여 입력받은 수까지 출력
            }
            Console.Write("\n");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            EventHandlerClass obj = new EventHandlerClass();
            button.Push += new EventHandler(obj.MyMethod); //이벤트 처리 등록
            button.OnPush();
        }
    }
}
