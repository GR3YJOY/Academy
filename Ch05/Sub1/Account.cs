using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Account
    {
        //속성
        public string bank;
        public string id;
        public string name;
        public int balance;

        //기능
        public void Deposit(int money)
        {
            this.balance += money;
        }

        public void Withdraw(int money) 
        {
            this.balance += money;
        }

        public void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("은행명: "+bank);
            Console.WriteLine("계좌번호: "+id);
            Console.WriteLine("입금주: "+name);
            Console.WriteLine("현재잔액: "+balance);
            Console.WriteLine("------------------");

            //Account 객체생성
            Account kb = new Account();

            //초기화
            kb.bank = "국민은행";
            kb.id = "101-12-1234";
            kb.name = "김유신";
            kb.balance = 10000;

            //기능
            kb.Deposit(25000);
            kb.Withdraw(5000);
            kb.Show();

            // nh 객체생성
            Account nh = new Account();
            nh.bank = "농협";
            nh.id = "120-11-1424";
            nh.name = "김춘추";
            nh.balance = 30000;

            nh.Deposit(70000);
            nh.Withdraw(20000);
            nh.Show();
        }
    }
}
