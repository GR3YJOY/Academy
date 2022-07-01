using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH06
{
    internal class P209
    {
        //코드5-2

        static void Main1(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
        }
    }
}
