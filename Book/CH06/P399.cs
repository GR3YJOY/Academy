using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH06
{
    internal class P399
    {
        //코드8-5
        class SquareClaculator
        {
            public int this[int i]
            {
                get { return i * i; }
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                SquareClaculator squareClaculator = new SquareClaculator();
                Console.WriteLine(squareClaculator[10]);
                Console.WriteLine(squareClaculator[20]);
                Console.WriteLine(squareClaculator[30]);
            }
        }
    }
}
