﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 날짜 : 2022/06/17 (결석)
 * 이름 : 조귀애
 * 내용 : 클래스 연습문제
 */
namespace Test
{
	internal class _3_01
	{
		private string name;
		private int age;

		public _3_01(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public void Show()
		{
			Console.WriteLine("================");
			Console.WriteLine("이름 : " + this.name);
			Console.WriteLine("나이 : " + this.age);
			Console.WriteLine("----------------");
		}

		static void Main1(string[] args)
		{
			_3_01 kim = new _3_01("김유신", 23);
			_3_01 lee = new _3_01("이순신", 31);

			kim.Show();
			lee.Show();
		}
	}
}
