using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH03
{
    internal class P129
    {
        static void Main1(string[] args)
        {
            //코드3-3
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            //코드3-4
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }

            if (DateTime.Now.Hour >= 12)
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
