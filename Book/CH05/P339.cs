﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH05
{
    internal class P339
    {
        class Program
        {
            class Animal
            {
                private void Private() { }
                protected void Protected() { }
                public void Public() { }

                public void TestA()
                {
                    Private();
                    Protected();
                    Public();
                }
            }

            class Dog : Animal
            {
                public void TestB()
                {
                    Protected();
                    Public();
                }
            }
            static void Main1(string[] args)
            {
                Dog dog = new Dog();
                dog.Public();
            }
        }
    }
}
