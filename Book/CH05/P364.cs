using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    internal class P364
    {
        //코드7-28
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("냠냠 먹습니다.");
            }

        }

        class Dog : Animal
        {
            public void Eat()
            {
                Console.WriteLine("강아지 사료를 먹습니다.");
            }
        }

        class Cat : Animal
        {
            public void Eat()
            {
                Console.WriteLine("고양이 사료를 먹습니다.");
            }
        }

        static void Main1(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog(),
            };

            foreach (var item in Animals)
            {
                item.Eat();
            }
        }
    }
}
