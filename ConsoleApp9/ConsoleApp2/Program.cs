using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ex : Exception { }
    class ExerciseCh6_10_2
    {
        public static void Main()
        {
            Console.WriteLine("Entering first try block");
            try //첫번째 try
            {
                Console.WriteLine("Entering second try block"); 
                try //두번째 try
                {
                    throw new Ex(); //두번째 try블록에서 예외 발생
                }
                finally  //예외발생 상관없이 무조건 실행되는 finally 블록
                {
                    Console.WriteLine("finally in 2nd try block");
                }
            } catch(Ex e) //첫번째 try 블록에서 예외 발생
            {
                Console.WriteLine("Caught Ex in first try block");
            }
            finally  //예외발생 상관없이 무조건 실행되는 finally 블록
            {
                Console.WriteLine("finally in 1st try block"); //무조건 finally in 1st try block 출력
            }
        }
    }
}
