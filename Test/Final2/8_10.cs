﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/28
 * 이름 : 조귀애
 * 내용 : [총정리문제] 구구단 출력
 */

namespace Test.Final2
{
    internal class _8_10
    {
        static void Main10(string[] args)
        {
            for (int y = 1; y <= 9; y++)
            {
                for (int x = 2; x <= 9; x++)
                {
                    Console.Write("{0}x{1}={2,2} ", x, y, x*y);
                }
                Console.WriteLine();
            }
        }
    }
}
