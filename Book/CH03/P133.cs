using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH03
{
    internal class P133
    {
        static void Main1(string[] args)
        {
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침먹을시간입니다.");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심먹을시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁먹을시간입니다.");
                }
            }

        }
    }
}
