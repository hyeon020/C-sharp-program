using ConsoleApp8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp8
{
    class Exercise
    {
        public static void Main()
        {
            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("This is line one");
                w.WriteLine("This is line two");
            }
            using (TextReader r = File.OpenText("log.txt"))
            {
                int c;
                while((c = r.Read()) != -1)
                {
                    Console.Write((char)c);
                }
            }
        }
    }
}