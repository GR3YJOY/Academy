﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH04
{
    internal class P268
    {
        //코드6-3
        class Program
        {
            class Test
            {
                public void Print()
                {
                    Console.WriteLine("Print() 메서드가 호출되었습니다");
                }
            }
            static void Main1(string[] args)
            {
                Test test = new Test();
                test.Print();
                test.Print();
                test.Print();
            }
        }
    }
}
