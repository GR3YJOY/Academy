﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/24
 * 이름: 조귀애
 * 내용: 예외처리 연습문제
 */

namespace Test._06
{
    internal class _6_01
    {
        static void Main1(string[] args)
        {
            Dictionary<string, string> colorDic =new Dictionary<string, string>();

            colorDic.Add("red", "빨간색");
            colorDic.Add("green", "초록색");
            colorDic.Add("blue", "파란색");

            try
            {
                colorDic.Add("red", "빨강");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("yellow : {0}", colorDic["yellow"]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var v in colorDic)
            {
                Console.WriteLine("colorTable[{0}] : {1}", v.Key, v.Value);
            }

            Console.WriteLine("프로그램 종료...");
        }
    }
}
