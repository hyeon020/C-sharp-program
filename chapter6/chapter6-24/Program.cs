using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace chapter6_24
{
    public void ThreadBody()
    {
        Thread myself = Thread.CurrentThread;
        lock (this) //lock문 
        {
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine("{0} is activated => {1}", myself.Name, i);
                Thread.Sleep(1000);
            }
        }
    }
}
