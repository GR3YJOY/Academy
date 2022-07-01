using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/30
 * 이름 : 조귀애
 * 내용 : [총정리 문제] 클래스 연습
 */

namespace Test.Final4
{
    class Box
    {
        private double width;
        private double height;
        private double depth;

        ????????????



        public double Volume()
        {
            return width * height * depth;
        }
    }

    internal class _10_01
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(10, 20, 30);
            Box box2 = new Box(3, 6, 9);

            Console.WriteLine("box1 부 피 : "+box1.Volume);
            Console.WriteLine("box2 부 피 : "+box2.Volume);
        }
    }
}
