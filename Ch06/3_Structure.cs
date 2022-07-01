using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 날짜: 2022/06/14
 * 이름: 조귀애
 * 내용: 구조체 실습하기 교재 p404
 * 
 * 구조체(Structure)
 *  -간단하게 객체를 만들때 사용하는 구조 형식
 *  -클래스와 동일하지만 몇가지 제한(상속 X, 캡슐화 X)
 */

namespace Ch06
{
    struct MyPoint  //struct대신 class로 해도 됨
    {
        public int x;
        public int y;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 필드(속성) 출력 메서드 ToString()
        public override string ToString()  //override는 부모클래스의 메서드를 재정의한 것
        {
            return String.Format($"x: {x}, y: {y}");
        }
    }


    internal class _3_Structure
    {
        static void Main3(string[] args)
        {
            MyPoint p1;
            p1.x = 10;
            p1.y = 20;

            Console.WriteLine("p1 : "+p1.ToString());

            MyPoint p2 = new MyPoint(20, 30);
            Console.WriteLine("p2 : "+p2.ToString());
        }
    }
}
