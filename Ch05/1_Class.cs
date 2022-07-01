using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/06/08 
 * 이름: 조귀애
 * 내용: 클래스와 객체 실습하기 교재 p200
 * 
 * 1.클래스와 객체
 *   -클래스는 객체를 생성하는 구조체이며, 필드와 메서드로 구성된다.
 *   -객체는 클래스의 실제 인스턴스이며, new 연산자로 생성한다.
 * 
 * 2.객체지향 프로그래밍(OOP :  Object Oriented Programming) :
 *    현실세계의 객체 모델을 바탕으로 프로그램을 구조화하고 객체간의 상호작용을 개발하는 프로그래밍 기법
 *    대규모 소프트웨어 개발에 적합
 *       
 *   -객체(Objedt) : 하나의 독립적인 개체로, 필드(속성)과 메서드(기능)로 구성되며 객체의 추상화를 위해 클래스를 설계
 *      
 *   -캡슐화(정보은닉): 객체의 정보노출을 최소화하고 꼭 필요한 정보만 노출하는 기법.
 *      
 *   -상속: 기존에 만들어 놓은 클래스의 기능을 그대로 물려받아서 사용하는 것.
 *         이렇게 하면 기존의 코드가 재사용되기 때문에 상당히 효율적인 프로그래밍 가능.
 *            
 *   -다형성: 같은 이름의 기능을 하는 요소를 여러개 만드는 것.
 *        ex) A라는 이름의 메서드 여러개가 각각 다른 기능을 하도록 만들수 있음.
 *              
 * 3.메서드, 클래스 이름: 대문자로 시작 / 변수: 소문자로 시작 (약속)
 */
namespace Ch05
{
    internal class _1_Class
    {
        static void Main1(string[] args)
        {
            // 객체 생성
            Car sonata = new Car();

            // 객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            // 객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            // 객체 생성(bmw, 검정색)
            Car bmw = new Car();
            bmw.name = "페리도트그린";
            bmw.color = "검정색";
            bmw.speed = 0;

            bmw.SpeedUp(10);
            bmw.SpeedUp(50);
            bmw.SpeedDown(20);
            bmw.Show();
        }
    }
}
