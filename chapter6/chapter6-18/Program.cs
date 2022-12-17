using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; //반드시 포함!

namespace chapter6_18
{
    class SimpleThreadApp
    {
        static void ThreadBody()
        {
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(DateTime.Now.Second + " : " + i);
                Thread.Sleep(1000); //1초 지정
            }
        }
        public static void Main()
        {
            ThreadStart ts = new ThreadStart(ThreadBody);
            Thread t = new Thread(ts);
            Console.WriteLine("*** Start of Main");
            t.Start(); //시작
            Console.WriteLine("*** End of Main");
        }
    }
}
