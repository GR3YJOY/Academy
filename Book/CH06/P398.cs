using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH06
{
    internal class P398
    {
        //코드8-4
        class Products
        {
            public int this[int i]
            {
                get { return i; }
                set { Console.WriteLine(i + "번째 상품 설정"); }
            }
        }

        static void Main1(string[] args)
        {
            Products products = new Products();
            Console.WriteLine(products[5] + "번째 상품 설정");
        }
    }
}
