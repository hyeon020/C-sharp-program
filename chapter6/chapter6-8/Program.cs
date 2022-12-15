using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter6_8
{
    class UserErrException : ApplicationException 
    {
        public UserErrException(string s) : base(s)
        { }
    }
    class UserException
    {
        public static void Main()
        {
            try
            {
                throw new UserErrException("throw a exception with a message"); //출력결과
            }
            catch(UserErrException e) 
            { 
                Console.WriteLine(e.Message);
            }
        }
    }
}
