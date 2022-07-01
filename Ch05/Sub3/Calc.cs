using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub3
{
    internal class Calc
    {
        // 싱글톤 객체
        private static Calc instance = new Calc(); //멤버변수이기때문에 private,

        public static Calc Instance { get { return instance; } }

        private Calc() { }   //생성자가 private여서 new Calc하지 못함


        public int Plus(int x, int y) 
        {
            return x + y;
        }
        public int Minus(int x, int y) 
        {
            return x - y;
        }
        public int Muiti(int x, int y) 
        {
            return x * y;
        }
        public int Div(int x, int y) 
        {
            return x / y;
        }
    }
}
