using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GClass<T> //제네릭 클래스
    {
        private List<T> list;
        public GClass() //디폴트 생성자
        {
            list = new List<T>();
        }
        public String getValue()
        {
            String str = ""; //문자열 str 지정
            foreach (T e in list) str += (e.ToString() + " "); //문자열로 비꾸어 공백으로 구분하여 연결
            return str; //연결한 문자열 반환
        }
        public void setValue(params T[] args)
        {
            foreach (T e in args) list.Add(e);
        }
    }
    public class ExerciseCh6_10_1
    {
        public static void Main(String[] args)
        {
            GClass<int> gInteger = new GClass<int>(); //정수형 매개변수로 객체 ginteger 생성
            gInteger.setValue(10, 20, 30);  //ginteger의 list에 10,20,30 삽입
            Console.WriteLine(gInteger.getValue()); //공백으로 구분한 문자열로 출력
        }
    }
}
