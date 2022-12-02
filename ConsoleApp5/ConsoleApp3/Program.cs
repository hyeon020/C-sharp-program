using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Date
    {
        private int day, month, year;
        public Date(int mm, int dd, int yy)
        {
            day = dd;
            month = mm;
            year = yy;
        }
        public static bool operator ==(Date a, Date b) // ==연산자
        {
            if (a.day == b.day && a.month == b.month && a.year == b.year) return true;
            else return false;
        }

        public static bool operator !=(Date a, Date b) // != 연산자
        {
            if (a.day == b.day && a.month == b.month && a.year == b.year) return false;
            else return true;
        }

        public static bool operator >(Date a, Date b) // >연산자
        {
            if (a.year > b.year) return true;
            else if (a.year == b.year && a.month > b.month) return true;
            else if (a.year == b.year && a.month == b.month && a.day > b.day) return true;
            else return false;
        }

        public static bool operator <(Date a, Date b) // <연산자
        {
            if (a.year > b.year) return false;
            else if (a.year == b.year && a.month > b.month) return false;
            else if (a.year == b.year && a.month == b.month && a.day > b.day) return false;
            else return true;
        }

        public static Date operator ++(Date a)
        { 
          
            int aYear = a.year;
            int aMonth;
            int aDay;

            if (a.day == 30)
            {
                aMonth = a.month++; //++연산자

                return new Date(aMonth, 1, aYear);
            }
            else
            {
                aMonth = a.month;
                aDay = a.day++;
                return new Date(aMonth, aDay, aYear);
            }

        }

        public static Date operator --(Date a)
        { 
            int aYear = a.year;
            int aMonth, aDay;

            if (a.day == 1)
            {
                aMonth = a.month--;   //--연산자
                aDay = 30;
                return new Date(aMonth, aDay, aYear);
            }
            else
            {
                aMonth = a.month;
                aDay = a.day--;  
                return new Date(aMonth, aDay, aYear);
            }

        }


        public static Date operator +(Date d, int n)
        { 
            int aDay, aMonth, aYear;
            if (d.day + n > 30)
            {
                aYear = d.year;
                aMonth = d.month + 1;
                aDay = d.day + n - 30; //날짜에 대한 -연산자
            }
            else
            {
                aYear = d.year;
                aMonth = d.month;
                aDay = d.day + n;  //날짜에 대한 + 연산자
            }

            return new Date(aMonth, aDay, aYear);
        }
        public static Date operator -(Date d, int n)
        {
            int aDay, aMonth, aYear;
            if (d.day - n < 0)
            {
                aYear = d.year;
                aMonth = d.month--;
                aDay = 30 + (d.day - n);
            }
            else
            {
                aYear = d.year;
                aMonth = d.month;
                aDay = d.day - n;
            }

            return new Date(aMonth, aDay, aYear);
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", month, day, year);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Date date1 = new Date(06, 15, 2022);
            Date date2 = new Date(06, 26, 2022);
            Date date3 = new Date(06, 30, 2022);
            Date date4 = new Date(06, 01, 2022);

            Console.WriteLine("date1==date2 : {0}", date1 == date2);
            Console.WriteLine("date1!=date2 : {0}", date1 != date2);
            Console.WriteLine("date1>date2 : {0}", date1 > date2);
            Console.WriteLine("date1<date2 : {0}", date1 < date2);
            Console.WriteLine("{0}++ : {1}", date3.ToString(), date3++.ToString());
            Console.WriteLine("{0}-- : {1}", date4.ToString(), date4--.ToString());
            Console.WriteLine("{0} +5 : {1}", date1.ToString(), (date1 + 5).ToString());

        }
    }
}
