﻿using System;

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