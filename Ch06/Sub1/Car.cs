using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    abstract class Car                             //internal 생략가능    
    {
        //속성(필드)
        protected string name;          
        protected string color;
        protected int speed;

        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        //기능(메서드)
        public abstract void SpeedUp(int speed);   //메서드내용 필요없음 자식클래스에서 구체적으로 쓰기 때문
        public abstract void SpeedDown(int speed); //virtual은

        public virtual void Show()
        {
            Console.WriteLine("==============");
            Console.WriteLine("차량명: "+name);
            Console.WriteLine("차량색: "+color);
            Console.WriteLine("차량속도: "+speed);
        }

    }
}
