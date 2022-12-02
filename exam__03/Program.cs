using System;

using System.IO;

namespace exam__03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(args[0]); //명령행 인자 정수로 변환하여 A에 저장
            int B = int.Parse(args[1]); //명령행 인자 정수로 변환하여 B에 저장

            FileStream fs;
            try
            {
                fs = new FileStream("input.dat", FileMode.Open); //input 파일을 읽음
            }
            catch(IOException)                                 //예외 상황
            {
                Console.Write("Input파일을 열 수 없습니다."); //파일을 열수 없다고 출력
                return;
            }
            StreamReader r = new StreamReader(fs); //StreamReader객체 r 생성
            string s = r.ReadLine();               //s에 저장
            double C = double.Parse(s);           //문자열 s를 double형으로 변환하여 C에 저장
            int num = 0, result = 1;             //num을 0으로 초기화, result를 1로 초기화

            FileStream os;
            try
            {
                os = new FileStream("output.dat", FileMode.Create);  //output파일을 만듦
            }
            catch(IOException)                                     //예외상황
            {
                Console.Write("Output파일을 열 수 없습니다.");  //파일을 열수 없다고 출력
                return;
            }
            StreamWriter w = new StreamWriter(os);             //StreamWriter객체 w 생성

            for(int i = A; i<=B; i++)
            {
                if(i == A)
                {
                    Console.Write("(" + i + "*....*");       //i가 A라면 (A*....*을 출력
                    w.Write("(" + i + "*....*");             //똑같이 파일에 쓰기
                }
                else if(i == B)
                {
                    Console.Write(i);                        //i가 B라면 i
                    w.Write(i);                              //똑같이 파일에 쓰기
                }

                num = i;                                    //num에 i값 저장
                result *= num;                             //결과는 num을 누적하여 곱함
               
            }

            Console.Write(")/(2*" + C);                    //)/(2*C를 출력
            w.Write(")/(2*" + C);                         //파일에 쓰기
            C = result / (2 * C);                         // 결과값 C는 result를 2*C로 나눈 값

            Console.WriteLine(")=" + C);                  //)= C를 출력
            w.WriteLine(")=" + C);                        //파일에 쓰기

            r.Close();                                    //r(StreamReader)닫기
            w.Close();                                    //w(StreamWriter)닫기
        }
    }
}
