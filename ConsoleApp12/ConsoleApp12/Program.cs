using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 9, y = 3; //x와 y값 초기화
            Console.WriteLine(x + " & " + y + " = " + (x & y));
            Console.WriteLine(x + "     " + y + " = " + (x | y));
            Console.WriteLine(x + " ^ " + y + " = " + (x ^ y));
            Console.WriteLine("~10 = " + (~10));
        }
    }
}
