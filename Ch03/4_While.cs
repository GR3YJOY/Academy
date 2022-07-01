using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022/06/07
 * 이름 : 조귀애
 * 내용 : 반복문 while 실습하기 교재 p162 
 *        for문은 반복횟수가 정해져있지만, while문은 그렇지않으며 조건에 따라 반복
 */

namespace Ch03
{
    internal class _4_While
    {
        static void Main1(string[] args)
        {
            // 1부터 10까지 합
            int sum = 0;
            int k = 1;             //초기식
            while (k <= 10)        //while (조건식)
            {
                sum += k;
                k++;               //증감식
            }

            Console.WriteLine("1부터 10까지 합 : " +sum);


            // do ~ while : 최초 한번은 무조건 반복 실행, 그 이후 반복할 지 정하는 것
            int total = 0;
            int i = 1;

            do
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
                i++;                 //탈출을 위해 변수 더함
            }
            while(i <= 10);

            Console.WriteLine("1부터 10까지 짝수합 : "+total);


            // break
            int num = 0;
            
            while (true)
            {
                if (num % 5 == 0 && num % 7 == 0)
                {
                    break;              //반복문 종료
                }
                num++;
            }

            Console.WriteLine("5와 7의 최소공배수 : "+num);


            // continue
            int tot = 0;
            int j = 0;

            while (j <= 10)
            {
                if (j % 2 == 1)
                {
                    continue;         //반복문의 처음으로 이동
                }

                tot += j;
            }

            Console.WriteLine("1부터 10까지 짝수합 : " +tot);

        }
    }
}
