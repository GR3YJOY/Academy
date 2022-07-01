using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/30
 * 이름 : 조귀애
 * 내용 : [총정리 문제] 클래스와 객체
 */

namespace Test.Final4
{
    class Adder
    {
        public Adder(int x)
        {
            this.x = x;
        }
        public void Add(int x)
        {
            this.x = x;
        }

        public void Add(int x)
        {
            this.x = x + 50;
        }

        public void Add(int[] arr)
        {
            arr[0]++;
        }
        public void Add(Adder al)
        {
            al.x = al.x + 40;
        }
        public ??? Add(Adder a2, int value)
        {
            return new Adder(value);
        }
    }

    internal class _10_03
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };

            Adder adder = new Adder(100);

            adder.Add(100);
            Console.WriteLine("1) "+ adder.x);

            adder.Add(adder) = new Adder(100);
            Console.WriteLine("2) "+ adder.x);

            adder.Add(arr);
            Console.WriteLine("3) "+ arr[0]);

            adder = adder.Add(adder, 1);
            Console.WriteLine("4) "+ adder.x);
        }
    }
}
