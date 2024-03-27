using System;

namespace Proj3
{
    internal class Rect
    {
        public double Width;
        public double Height;

        // 메소드 오버로딩 Method Overloading
        // 매개변수의 개수나 타입만 다르면, 이름이 같아도 문제가 발생하지 않음.
        public Rect() // 매개변수 개수와 타입으로 판단함. 메소드 이름은 같아도 됨.
        {

        }
        public Rect(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get {
                return Width * Height;
            }
        }

        public bool ChangeWidth(double size)
        {
            if (Width + size < 0) {
                return false;
            }

            Width += size;
            return true;
        }

        public bool ChangeHeight(double size)
        {
            if (Height + size < 0) {
                return false;
            }
            Height += size;
            return true;
        }
    }
}