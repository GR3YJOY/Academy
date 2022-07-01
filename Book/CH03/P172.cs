using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH03
{
    internal class P172
    {
        static void Main1(string[] args)
        {
            //코드4-17
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            //코드4-18
            string[] array2 = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
