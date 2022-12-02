using System;
using System.Runtime.InteropServices;

namespace ConsoleApp4
{
    delegate void ExDelegator(string str);
    class Ex
    {
        public static void StaticMethod(String str)
        {
            Console.Write(str);
            Console.WriteLine("\tFramework");
        }
        public void InstanceMethod(string str)
        {
            Console.Write(str);
            Console.WriteLine("\tProgramming Language");
        }
    }
    class ExerciseCh4_7_2
    {
        public static void Main() 
        {
            Ex ex = new Ex();
            ExDelegator d1 = new ExDelegator(ex.InstanceMethod);
            ExDelegator d2 = new ExDelegator(Ex.StaticMethod);
            d1("C#");
            d2(".NET");
        }
    }  
}
