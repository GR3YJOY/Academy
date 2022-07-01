using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH06
{
    internal class P210
    {
        //코드5-3 0부터 10사이의 실수 난수
        static void Main1(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
        }

    }
}
