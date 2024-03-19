using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    public class Score
    {
        // 필드(field): class안에 선언한 변수
        public int Kor;
        public int Eng;
        public int Mat;

        // 메소드(method): class안에 선언한 기능(행동)

        // public int Average()
        // {
        //     var result = (Kor + Eng + Mat) / 3;
        //     return result;
        // }

        // 프로퍼티(속성). 시험에 나옴
        // 내부: 메소드, 외부: 변수
        public int Average{   // get: ?? set: ??
            get{
                return ((Kor + Eng + Mat) / 3);
            } 

        }

        //public static double Average(int Kor, int Eng, int Mat)
        //{
        //    return ((Kor + Eng + Mat) / 3);
        //} 얜 걍 내가 해본거
    }
}
