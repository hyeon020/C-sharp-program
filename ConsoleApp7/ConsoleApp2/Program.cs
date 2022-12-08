using System;

namespace p260_9
{
    class Program
    {
        interface IOperation
        {
            void Insert(string str);
            string Delete();
            bool Search(string str);
            string GetCurrentElt();
            int NumOfElements();
        }

        class Stack : IOperation
        {
            int size;   //스택의 크기
            string[] arr;   //스택을 구현할 문자열 배열
            int sp = -1;   //스택 포인터

            public Stack() //디폴트 생성자
            {
                this.size = 100;
                this.arr = new string[size];
            }
            public Stack(int size) //스택의 크기를 받는 생성자
            {
                this.size = size;
                this.arr = new string[size];
            }

            public void Insert(string str) //매개변수로 받은str을 스택에 푸시하는 메소드
            {
                if (sp == size)
                {
                    Console.WriteLine("스택 오버플로우");
                }
                arr[++sp] = str;
            }

            public string Delete()
            {
                if (sp == -1)
                {
                    Console.WriteLine("스택 언더플로우");
                    return "";
                }
                return arr[sp--];
            }

            public bool Search(string str) //원소의 존재여부를 반환
            {
                for (int i = 0; i <= sp; i++)
                {
                    if (str.Equals(arr[i])) //만약 스택에 있으면
                        return true;       //true 반환
                }
                return false;   //스택에 없으면 false 반환
            }

            public string GetCurrentElt() { return arr[sp]; } //현재 스택의 탑에 있는 원소를 반환

            public int NumOfElements() { return sp + 1; } //스택에 존재하는 원소의 개수를 반환
        } 

        class Queue : IOperation
        {
            int front = 0;
            int rear = 0;
            int size;        //큐의 크기
            int count = 0;  //원소의 개수를 저장할 변수
            string[] arr;   //원형큐 구현할 문자열 배열

            public Queue()
            {
                this.size = 100;
                this.arr = new string[size];
            }
            public Queue(int size) //큐의 크기를 받는 생성자
            {
                this.size = size;
                this.arr = new string[size];
            }

            public void Insert(string str) //매개변수로 받은str을 큐의 rear에 삽입
            {
                if (count == size)
                {
                    Console.WriteLine("큐오버플로우");
                }
                arr[(rear) % size] = str;
                rear++; //rear증가
                count++; //count
            }

            public string Delete()  //큐의 front에서 제거한 후 반환
            {
                if (count == 0)
                {
                    Console.WriteLine("큐언더플로우");
                    return "";
                }
                string s = arr[(front) % size];
                front++;
                count--;
                return s;
            }

            public bool Search(string str)  //큐 원소의 존재여부를 반환
            {
                for (int i = front; i < front + count; i++)
                {
                    if (arr[i % size].Equals(str))
                        return true;
                }
                return false;
            }

            public string GetCurrentElt() { return arr[front]; } //현재 큐의 front에 있는 원소를 반환하는 메소드

            public int NumOfElements() { return count; } //큐에 존재하는 원소의 개수를 반환하는 메소드
        }
        static void Main(string[] args)
        {
            Console.WriteLine("스택 테스트 결과"); //스택 테스트
            Stack s = new Stack(10);    //크기가 10인 스택 생성

            s.Insert("가"); //Insert() 메소드 테스트
            Console.WriteLine("Insert() : 가");
            s.Insert("나"); //Insert() 메소드 테스트
            Console.WriteLine("Insert() : 나");
            s.Insert("다"); //Insert() 메소드 테스트
            Console.WriteLine("Insert() : 다");
           
            Console.WriteLine("Delete() : " + s.Delete()); //Delete() 메소드 테스트
          
            string str = "가"; //Search() 메소드 호출 테스트
            if (s.Search(str))
                Console.WriteLine($"\"{str}\"는 스택에 있습니다.");
            else
                Console.WriteLine($"\"{str}\"는 스택에 없습니다.");
            
            Console.WriteLine("GetCurrentElt() : " + s.GetCurrentElt()); //GetCurrentElt() 메소드 호출 테스트
            Console.WriteLine("NumOfElements() : " + s.NumOfElements()); //NumOfElements() 메소드 호출 테스트

            Console.WriteLine("\n큐 테스트 결과"); //큐 테스트
            Queue q = new Queue(10);    //크기가 10인 원형큐 생성

            q.Insert("라"); //Insert() 메소드 테스트
            Console.WriteLine("Insert() : 라");
            q.Insert("마"); //Insert() 메소드 테스트
            Console.WriteLine("Insert() : 마");
            q.Insert("바"); //Insert() 메소드 테스트
            Console.WriteLine("Insert() : 바");
            
            Console.WriteLine("Delete() : " + q.Delete()); //Delete() 메소드 호출 테스트
            str = "이"; //Search() 메소드 테스트
            if (q.Search(str))
                Console.WriteLine($"\"{str}\"는 큐에 있습니다.");
            else
                Console.WriteLine($"\"{str}\"는 큐에 없습니다.");
            
            Console.WriteLine("GetCurrentElt() : " + q.GetCurrentElt()); //GetCurrentElt() 메소드 테스트
            Console.WriteLine("NumOfElements() : " + q.NumOfElements()); //NumOfElements() 메소드 테스트
        }
    }
}
