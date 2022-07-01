using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH02
{
    internal class P092
    {
        static void Main1(string[] args)
        {
            //코드2-39
            string output = "hello ";
            output += "world ";
            output += "!";

            Console.WriteLine(output);

            //코드2-40
            string output1 = "hello ";
            output1 = output1 + "world ";
            output1 = output1 + "!";

            Console.WriteLine(output1);
        }
    }
}
