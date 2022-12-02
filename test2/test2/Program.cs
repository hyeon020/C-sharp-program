using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class GenericApp
    {
        public string Connect<T>(int OP, T a, string b)
        {
            string result = "";
            if (OP == 1)
            {               
                result = b.ToString() + a.ToString() + b.ToString();
            }
            else if (OP == 0)
            {             
                result =  a.ToString() + b.ToString() + b.ToString();
            }
            return result;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1;
            int OP;
            int int_indata;
            double double_indata;
            GenericApp conn = new GenericApp();
            Console.Write(" Read OP string from keyboard ? : ");
            OP = int.Parse(Console.ReadLine());
            if (OP == 0)
            {
                Console.Write(" Read  string from keyboard ? : ");
                str1 = Console.ReadLine();
                Console.Write(" Read int data from keyboard ? : ");
                int_indata = int.Parse(Console.ReadLine());
                Console.WriteLine(conn.Connect(OP, int_indata, str1));
            }
            else if(OP == 1)
            {
                Console.Write(" Read  string from keyboard ? : ");
                str1 = Console.ReadLine();
                Console.Write(" Read double data from keyboard ? : ");
                double_indata = double.Parse(Console.ReadLine());
                Console.WriteLine(conn.Connect(OP, double_indata, str1));
            }
        }
    }
}
