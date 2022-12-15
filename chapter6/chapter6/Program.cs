using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter6
{
    internal class SimpleGeneric<T>
    {
        private T[] values;
        private int index;
        public SimpleGeneric(int len) { //Constructor
            values = new T[len];
            index = 0;
    }
        public void Add(params T[] args)
        {
            foreach (T e in args)
                values[index++] = e;
        }
        public void Print()
        {
            foreach (T e in values)
                Console.Write(e + " ");
            Console.WriteLine();
        }
    }
    public class GenericClassApp
    {
        public static void Main()
        {
            SimpleGeneric<Int32> gInteger = new SimpleGeneric<Int32>(10);
            SimpleGeneric<Double> gDouble = new SimpleGeneric<Double>(10);
            gInteger.Add(1, 2);
            gInteger.Add(1, 2, 3, 4, 5, 6, 7);
            gInteger.Add(0);
            gInteger.Print();
            
            gDouble.Add(10.0, 20.0, 30.0);
            gDouble.Print();
        }
    }
}
