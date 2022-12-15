using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter6
{
    interface IGenericInterface<T> //형매개변수 선언
    {
        void SetValue(T x);
        string GetValueType();
    }
    class GenericClass<T> : IGenericInterface<T>
    {
        private T value;
        public void SetValue(T x)
        {
            value = x;
        }
        public String GetValueType()
        {
            return value.GetType().ToString();
        }
    }
    public class GenericInterfaceApp
    {
        public static void Main()
        {
            GenericClass<Int32> gInteger = new GenericClass<Int32>();
            GenericClass<String> gstring = new GenericClass<String>();
            gInteger.SetValue(10);
            gstring.SetValue("Text");
            Console.WriteLine(gInteger.GetValueType()); //
            Console.WriteLine(gstring.GetValueType());
        }
    }
}

