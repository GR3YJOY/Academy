using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    internal class P362
    {
        class Program
        {
            class Parent
            {
                public virtual void Method()
                {
                    Console.WriteLine("부모의 메서드");
                }
            }

            class Child : Parent
            {
                public override void Method()
                {
                    Console.WriteLine("자식의 메서드");
                }
            }

            static void Main1(string[] args)
            {
                Child child = new Child();
                child.Method();
                ((Parent)child).Method();
            }
        }
    }
}
