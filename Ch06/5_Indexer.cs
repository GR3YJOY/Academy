using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/14
 * 이름: 조귀애
 * 내용: 인덱서 실습하기 교재 p398
 * 
 * 인덱서(Indexer)
 *  -객체를 배열처럼 인덱스를 사용해서 객체의 데이터를 참조할 수 있게 해주는 속성
 *  -인덱서를 메서드로 대체 가능
 */

namespace Ch06
{
    class MyList
    {
        private int[] array;   //배열

        public MyList()        //배열 초기화
        {
            array = new int[3];
        }


        // 인덱서
        public int this[int i]
        {
            get { return array[i]; }
            set
            {
                if (i < array.Length)
                {
                    array[i] = value;
                }
                else
                {
                    Console.WriteLine("더 이상 데이터를 저장 할 수 없습니다.");
                }
            }
        }


        public int Length()
        {
            return array.Length;
        }
    }

    internal class _5_Indexer
    {
        static void Main5(string[] args)
        {
            MyList myList = new MyList();

            myList[0] = 100;
            myList[1] = 101;
            myList[2] = 102;
            myList[3] = 103; //<-- 더이상 ~ 없습니다 출력

            for (int i = 0 ; i < myList.Length() ; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
