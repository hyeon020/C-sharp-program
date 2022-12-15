using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace chapter6_3
{
    class GenericMethodApp
    {
        static void Swap<DateType>(ref DataType x, ref DataType y)
        {
            DataType temp;
            temp = x; x = y; y = temp;
        }
        public static void Main()
        {
            int a = 1, b = 2; double c = 1.5, d = 2.5;
            Console.WriteLine("Before: a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b); //swap은 값 
            Console.WriteLine(" After: a = {0}, b = {1}", a, b);
            Console.WriteLine(" Befor: c = {0}, d = {1}", c, d);
            Swap<double>(ref c, ref d);
            Console.WriteLine(" After: c = {0}, d = {1}", c, d);
        }
    }
}
