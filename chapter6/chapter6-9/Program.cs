using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter6_9
{
    class DivByZeroExceptionApp
    {
        public static void Main()
        {
            int i = 1, j = 0, k;
            k = i / j; //처리되지 않는 예제(0으로 나누려 함)
        }
    }
}
