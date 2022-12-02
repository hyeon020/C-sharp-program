using System;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs;  //파일스트림객체fs 생성
            try
            {
                fs = new FileStream("파일이름", FileMode.Open);        //"파일이름" 파일을 열어서 fs에 저장
            }
            catch (IOException)     //예외가 발생하면
            {
                Console.WriteLine("파일을 열 수 없습니다.");		//메시지 출력
                return;
            }
        }
    }
}