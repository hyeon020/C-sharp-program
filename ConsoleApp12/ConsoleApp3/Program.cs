using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Color { Red, Green, Blue };
namespace ConsoleApp2
{
    internal class Class1
    {
        public static void Main()
        {
            Color c = Color.Red;
            c++;
            int i = (int)c;
            Console.WriteLine("Cardinality of " + c + " = " + i);
        }
    }
}
