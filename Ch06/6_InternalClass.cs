using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/14
 * 이름: 조귀애
 * 내용: 자주 사용하는 내장 클래스 실습하기
 * 
 */

namespace Ch06
{
    internal class _6_InternalClass
    {
        static void Main6(string[] args)
        {
            ///////////////////////////////////////////
            // Math 클래스 (교재 P215)
            ///////////////////////////////////////////
            //Math math = new Math();
            Console.WriteLine("PI : "+Math.PI);  //PI는 상수니까 대문자
            Console.WriteLine("9 제곱근 : "+Math.Sqrt(9));
            Console.WriteLine("16 제곱근 : "+Math.Sqrt(16));
            Console.WriteLine("-5 절대값 : "+Math.Abs(-5));
            Console.WriteLine("1.2 올림값 : "+Math.Ceiling(1.2));
            Console.WriteLine("1.8 올림값 : "+Math.Ceiling(1.8));
            Console.WriteLine("1.2 내림값 : "+Math.Floor(1.2));
            Console.WriteLine("1.8 내림값 : "+Math.Floor(1.8));
            Console.WriteLine("1.2 반올림 : "+Math.Round(1.2));
            Console.WriteLine("1.8 반올림 : "+Math.Round(1.8));
            Console.WriteLine();

            ///////////////////////////////////////////
            // Random 클래스 (교재 p207)
            ///////////////////////////////////////////
            Random random = new Random();

            int rand1 = random.Next();
            Console.WriteLine( "rand1 : "+rand1);

            int rand2 = random.Next(10);             //0 ~ 9 사이의 임의의 정수
            Console.WriteLine("rand2 : " + rand2);

            int rand3 = random.Next(1, 11);          //1 ~ 10 사이의 임의의 정수
            Console.WriteLine("rand3 : " + rand3);

            double num1 = random.NextDouble();       //0 ~ 1 사이의 임의의 실수
            Console.WriteLine("num1 : "+num1);

            double num2 = num1 * 10;                 //0 ~ 10 사이의 임의의 실수
            Console.WriteLine("num2 : "+num2);

            double num3 = Math.Ceiling(num2);        //1~ 10 사이의 임의의 정수
            Console.WriteLine("num3 : "+num3);

            ///////////////////////////////////////////
            // DataTime 클래스
            ///////////////////////////////////////////
            //싱글톤 객체
            DateTime now = DateTime.Now;

            Console.WriteLine("now : " + now);

            // 개별 시간 데이터출력
            Console.WriteLine("년 : "+now.Year);
            Console.WriteLine("월 : "+now.Month);
            Console.WriteLine("일 : "+now.Day);
            Console.WriteLine("시 : "+now.Hour);
            Console.WriteLine("분 : "+now.Minute);
            Console.WriteLine("초 : "+now.Second);

            // 문자열 formet
            string result1 = now.ToString("yyyy-mm-dd");
            Console.WriteLine("result1 : "+result1);

            string result2 = now.ToString("yy-mm-dd hh:mm:ss");
            Console.WriteLine("result2 : "+result2);
        }
    }
}
