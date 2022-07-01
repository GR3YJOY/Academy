using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH02
{
    internal class P094
    {
        static void Main1(string[] args)
        {
            //코드2-42(1)
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);

            //코드2-42(2)
            int number1= 10;
            Console.WriteLine(number1);
            Console.WriteLine(++number1);
            Console.WriteLine(--number1);
            Console.WriteLine(number1);

            
        }
    }
}
