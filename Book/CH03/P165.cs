using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH03
{
    internal class P165
    {
        static void Main1(string[] args)
        {
            //코드4-11
            string input;
            do
            {
                Console.WriteLine("입력(exit을 입력하면 종료): ");
                input = Console.ReadLine();
            } 
            while (input != "exit");
        }
    }
}
