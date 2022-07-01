using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜: 2022/06/07
 * 이름: 조귀애
 * 내용: 반복문 실습하기 교재 p157,166
 *       반복문(Loop)은 프로그래밍에서 동일한 명령을 일정횟수만큼 반복해서 수행하도록 제어하는 명령문
 *       for(초기식; 조건식; 증감식)
 */

namespace Ch03
{
    internal class _3_For
    {
        static void Main1(string[] args)
        {
            //for문
            for (int i = 1; i <= 5; i++)  //초기식:변수선언, 조건식과 증감식이 참으로 성립, 조건식의 숫자에 따라 반복수도 달라짐
            {
                Console.WriteLine("{0}회 반복...", i);
            }


            //1부터 10까지 합
            int sum = 0;

            for (int k = 1; k<= 10; k++)
            {
                sum += k; // sum = sum + k;
            }

            Console.WriteLine("1부터 10까지 합 : " + sum);


            //1부터 10까지 짝수합
            int tot = 0;

            for (int v = 1; v <= 10; v++)
            {
                if (v % 2 == 0) // 짝수라면 : 나머지가 0, 홀수라면 : 나머지가 1
                {
                    tot += v;
                }
            }

            Console.WriteLine("1부터 10까지 짝수합 :" +tot);

            //중첩 for문
            for (int a=1; a<=3; a++) //3번 반복
            {
                Console.WriteLine("a : " + a);
                for (int b=1; b<=4; b++) //4번 반복
                {
                    Console.WriteLine("b :" + b);
                    for (int c = 1; c <= 5; c++) 
                    {
                        Console.WriteLine("c :" + c); //5번 반복 : 총 3번*4번*5번 = 60번 반복
                    }
                }
            }

            //구구단
            for (int x = 2; x <= 9; x++) 
            {
                Console.WriteLine("{0}단 시작", x);
                for (int y = 1; y <=9; y++)
                {
                    int z = x * y;

                    Console.WriteLine("{0} x {1} = {2}", x, y, z);
                }
            }


            //별삼각형
            for (int start = 1; start <= 10; start++)
            {
                for (int end = 1; end <= start; end++)
                {
                    Console.Write("★");
                }
                Console.WriteLine(); // 줄바꿈
            }

            Console.WriteLine(); // 줄바꿈


            //역별삼각형
            for (int start1 = 10; start1 >= 1; start1--)
            {
                for (int end1 = 1; end1 <= start1; end1++)
                {
                    Console.Write("★");
                }
                Console.WriteLine();
                
            }
        }
             
    }
}
