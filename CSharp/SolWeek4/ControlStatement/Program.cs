﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatement
{
    class Program
    {
        static void Test1() // 정적 메소드
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Console.WriteLine(number * 2);
        }
        static void Test2() // 정적 메소드
        {

        }
        void Test3() // instance 메소드
        {

        }
        static void Main(string[] args)
        {
            Test1();
        }


    }
}
