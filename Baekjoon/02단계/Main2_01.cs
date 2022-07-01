using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_01
    {
        static void Main1(string[] args)
        {
            string n = Console.ReadLine();
            string[] nn = n.Split();

            int a, b;
            a = int.Parse(nn[0]);
            b = int.Parse(nn[1]);

            if (a > b)
            {
                Console.WriteLine(">");
            }

            else if (a < b)
            {
                Console.WriteLine("<");
            }

            else 
            {
                Console.WriteLine("==");
            }
        }
    }
}
