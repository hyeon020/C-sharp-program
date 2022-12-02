using System;
using System.Threading;

namespace ConsolApp7
{
    class Account //계정 클래스
    {
        private double balance; 

        public Account(double initiaDeposit)    //생성자
        {
            balance = initiaDeposit;
        }

        public double Balance     //프로퍼티
        {
            get { return balance; }
            //set { balance = value; }
        }

        public void Deposit(double amount) //총액계산및기록
        {
            lock (this)     //lock문으로 스레드 제어
            {
                Thread.Sleep(1000);
                balance += amount;      //계정의 금액을 처리
            }
        }
    }

    class Teller //은행원클래스
    {
        string name;        //은행원이름
        Account account;    //처리할계정
        double amount;      //예금액

        public Teller(string name, Account account, double amount)  //생성자
        {
            this.name = name;
            this.account = account;
            this.amount = amount;
        }

        public void TellerTask()
        {
            account.Deposit(amount);
            Console.WriteLine(name + " : " + account.Balance);
        }
    }
    class Program_Test //테스트 프로그램
    {
        static void Main(string[] args)
        {
            Account account = new Account(10000);
            Teller t1 = new Teller("홍길동", account, 200);    //은행원(홍길동) 클래스 Teller 객체 t1 생성
            Teller t2 = new Teller("이순신", account, 700);    //은행원(이순신) 클래스 Teller 객체 t2 생성
                                                            
            Thread worker1 = new Thread(new ThreadStart(t1.TellerTask)); //홍길동의 스레드 객체 worker1 생성
            Thread worker2 = new Thread(new ThreadStart(t2.TellerTask)); //이순신의 스레드 객체 worker2 생성
            worker1.Start();    //홍길동의 스레드 실행
            worker2.Start();    //이순신의 스레드 실행
        }
    }
}