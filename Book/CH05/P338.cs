using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH05
{
    internal class P338
    {
        class Animal
        {
            public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
            public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        }

        class Dog : Animal
        {
            public void Test()
            {
                Eat();
                Sleep();
            }
        }

        static void Main1(string[] args)
        {

        }
    }
}
