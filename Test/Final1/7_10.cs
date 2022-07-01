using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/27
 * 이름 : 조귀애
 * 내용 : [총정리 문제] 
 * 
 */

namespace Test._07
{
    internal class _7_10
    {
        static void Main(string[] args)
        {
            string s = "before";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
        }

        public static void Test(string s)
        {
            s = "after";
        }

        public static void Test(ref string s2)
        {
            s2 = "after";
        }
    }
}
