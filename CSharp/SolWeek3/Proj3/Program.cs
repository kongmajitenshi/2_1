﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rect rect1 = new Rect();
            rect1.Width = 20.1;
            rect1.Height = 30.5;

            Rect rect2 = new Rect();
            rect2.Width = 2;
            rect2.Height = 3;

            rect1.SetWidth(20.0);
            rect1.SetHeight(-3);

            Console.WriteLine(rect1.Width);
            Console.WriteLine(rect1.Area);

            Console.WriteLine(rect2.Area);
            Console.WriteLine(rect2.GetArea());

        }
    }
}
