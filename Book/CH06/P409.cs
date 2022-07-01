using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH06
{
    internal class P409
    {
        //코드8-13
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }

            public Point(int x, int y, string test)
            {
                this.x=x;
                this.y=y;

                this.testB = test;
                this.testA = test;
            }          
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("");
        }
    }
}
