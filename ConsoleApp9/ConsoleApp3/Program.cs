using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class FinallyClause
    {
        public void MethodA()
        {
            try
            {
                Console.WriteLine("1");
            } catch(Exception e) //try 문에서 예외가 발생하면 실행되는 블록
            {
                Console.WriteLine("2");
            }
        }
        public void MethodB()
        {
            try
            {
                Console.WriteLine("3");
            }
            finally //무조건 출력해야 하는 구문
            {
                Console.WriteLine("4");
            }
        }
    }
    class ExcerciseCh6_10_3
    {
        public static void Main()
        {
            FinallyClause fc = new FinallyClause(); //객체 fc 생성
            fc.MethodA(); //1출력
            fc.MethodB(); //3,4 출력
        }
    }
}
