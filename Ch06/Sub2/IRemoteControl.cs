using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal interface IRemoteControl    //인터페이스 클래스 앞에는 대문자 I를 꼭 붙임
    {
        public abstract void PowerOn();
        public abstract void PowerOff();

        public void ChUp();             //abstract는 생략
        public void ChDown();

        public void SoundUp();
        public void SoundDown();
    }
}
