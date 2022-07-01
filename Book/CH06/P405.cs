using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH06
{
    internal class P405
    {
        //코드8-8
        class Program
        {
            struct Point
            {
                public int x;
                public int y;

                public Point(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                }
            }


            static void Main1(string[] args)
            {
                Point point = new Point();

                Console.WriteLine(point.x);
                Console.WriteLine(point.y);
            }
        }
    }
}
