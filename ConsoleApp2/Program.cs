using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ForeachStApp
    {
        public static void Main()
        {
            String[] color = {"red", "green", "blue"};
            foreach(string s in color)
                Console.WriteLine(s);
        }
    }
}
