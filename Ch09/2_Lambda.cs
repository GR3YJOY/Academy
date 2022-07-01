using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/21
 * 이름 : 조귀애
 * 내용 : 람다 실습하기 교재 p500
 * 
 * 람다식
 *  -함수적 프로그래밍을 지원하기 위한 문법 식
 *  -대리자를 조금 더 간편하게 사용하기 위한 식(익명 메서드)
 *  
 * 메모: 프로그램(P/G)에는 다양한 객체가 존재하며 객체가 다른 객체를 호출하는 연쇄반응이 일어난다.
 *  하지만 이러한 연쇄 과정은 오류가 생길 수 있기 때문에 절차적 지향방식인 람다식을 이용해 오류가 생기는 것을 막을 수 있다.
 *  대체자는 사실상 거의 사용되지 않고 있으며, 람다식을 많이 사용하는 추세.
 *  
 */

namespace Ch09
{
    internal class _2_Lambda
    {
        static void Main2(string[] args)
        {
            // 반환이 있는 람다식(Func 대리자)
            Func<string> f1 = () => { return "f1 실행"; };
            Func<int, string> f2 = (x) => { 
                return "f2 x : " + x; 
            };
            Func<int, int, string> f3 = (x, y) => { return $"f3 x: {x}, y: {y}"; }; //x,y의 매개변수 타입선언 하지않음 이미 나와있기 때문에

            string r1 = f1();
            string r2 = f2(3);
            string r3 = f3(3,4);

            Console.WriteLine("r1 :"+r1);
            Console.WriteLine("r2 :"+r2);
            Console.WriteLine("r3 :"+r3);

            // 반환이 없는 람다식(Action 대리자)
            Action a1 = () => Console.WriteLine("a1 실행"); //1줄이라 중괄호 필요 X
            Action<int> a2 = (x) => { Console.WriteLine("a2 x : "+x); };
            Action<int, int> a3 = (x, y) => { 
                Console.WriteLine($"a3 x : {x}, y : {y}"); 
            };

            a1();
            a2(3);
            a3(3, 4);

            // 람다식 활용
            List<int> dataset = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            dataset.ForEach((n) => { 
                Console.WriteLine(n + " ");
            });

        }
    }
}
