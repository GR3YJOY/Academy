using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH06
{
    internal class P396
    {
        //코드8-1
        class Wanted<T>
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Wanted<string> wantedString = new Wanted<string>("String");
                Wanted<int> wantedInt = new Wanted<int>(52237);
                Wanted<double> wantedDouble = new Wanted<double>(52.237);

                Console.WriteLine(wantedString.Value);
                Console.WriteLine(wantedInt.Value);
                Console.WriteLine(wantedDouble.Value);
            }
        }
    }
}
