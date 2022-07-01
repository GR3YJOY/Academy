using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH06
{
    internal class P406
    {
        //코드8-9,10,11
        class Program
        {
            struct Point
            {
                public int x;
                public int y;
            }

            static void Main1(string[] args)
            {
                Point point;
                point.x = 10;
                point.y = 10;

                Console.WriteLine(point.x);
                Console.WriteLine(point.y);
            }
        }
    }
}
