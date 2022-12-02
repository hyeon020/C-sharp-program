using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Stack
    {
        private int[] stack;
        int sp = -1;
        public Stack()
        {
            stack = new int[100]; //디폴트 생성자, 스택의 크기 100
        }
        public Stack(int size)
        {
            stack = new int[size];
        }

        public void Push(int data)
        {
            stack[++sp] = data; //메소드 Push()
        }

        public int Pop() //메소드 Pop()
        {
            return stack[sp--];

        }

        public void Print()
        {
            int spIndex = sp;

            if (sp == -1) Console.WriteLine("스택이 비어있음");
            else
            {
                while (sp != -1)
                {
                    Console.WriteLine("{0}", stack[sp--]); //정수 입력을 역순으로 출력
                }
            }

            sp = spIndex;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(0321);
            stack.Push(1230);
            stack.Print();


        }
    }
}
