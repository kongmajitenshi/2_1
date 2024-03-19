using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    public class Rect
    {
        public double Width;
        public double Height;

        public double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}
