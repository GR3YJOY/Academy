using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH05
{
    internal class P227
    {
        //코드 5-14
        class Product
        {
            public string name = "default";
            public int price = 1000;
        }

        static void Main1(string[] args)
        {
            Product productA = new Product() {name = "감자", price = 2000 };
            Product productB = new Product() {name = "고구마", price = 3000 };
        }
    }
}
