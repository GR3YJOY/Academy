using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH05
{
    internal class P228
    {
        //코드5-15
        class Product
        {
            public string name;
            public int price;
        }
        
        static void Main1(string[] args)
        {
            Product productA = new Product() { name = "감자", price = 2000};
            Product productB = new Product() { name = "고구마", price = 3000};
        }
    }
}
