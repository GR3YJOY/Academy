using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH03
{
    internal class P170
    {
        static void Main1(string[] args)
        {
            //코드4-16
            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
