using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Fraction
    {
        int numerator;
        int denominator;
        public Fraction(int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }
        public void PrintFraction() {
            Console.WriteLine(numerator + "/" + denominator);
        }
        class FractionApp{
            public static void Main() {
                Fraction f = new Fraction(1,2);
                f.printFraction();
            }
        }
    }
}
