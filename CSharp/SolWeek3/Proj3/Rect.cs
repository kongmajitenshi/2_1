using System;
using System.Runtime.Remoting.Messaging;

namespace Proj3
{
    internal class Rect
    {
        public double Width;
        public double Height;

        public double Area
        {
            get {
                return Width * Height;
            }
        }

        public double GetArea() //getter 이라고 부름. 내부의 값 꺼낼 때 씀.
        {
            return Width * Height;
        }

        public void SetWidth(double width)
        {
            Width = width;
        }

        public void SetHeight(double height)
        {
            Height = height;
        }

        public bool ChangeWidth(double width)
        {
            if(Width + width < 0)
            {
                return false;
            }
            Width += width;
            return true;
        }

        public bool ChangeHeight(double height)
        {
            if (Height + height < 0)
            {
                return false;
            }
            Height += height;
            return true;
        }
    }
}