using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car               //class: 그룹
    {

        //속성(필드)
        public string name;          //그룹의 멤버들(6개), 전부 public 생략가능
        public string color;
        public int speed;

        //기능(메서드)
        public void SpeedUp(int speed)      //{}: 선언만 해놓은 것 (내용없음)
        {
            this.speed += speed;           //속성필드의 speed와 기능의 speed는 다른 것, this는 class를 지칭하는 것
        }                                        
        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }
        public void Show()
        {
            Console.WriteLine("==============");
            Console.WriteLine("차량명: "+name);
            Console.WriteLine("차량색: "+color);
            Console.WriteLine("차량속도: "+speed);
        }

    }
}
