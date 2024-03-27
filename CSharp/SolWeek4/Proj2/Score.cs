using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Score
    {
        //인스턴스 필드(field) : class안에 선언한 변수
        public int Kor;
        public int Eng;
        public int Mat;

        //메소드(method): class안에 선언한 기능(행동)
        //메소드 == 함수(function)
        //public int Average()
        //{
        //    var result = (Kor + Eng + Mat) / 3;
        //    return result;
        //}

        //프로퍼티(속성)
        //내부:메소드 외부:변수
        public int Average
        {
            get {
                return (Kor + Eng + Mat) / 3;
            }
        }

        //매개변수 parameter
        //외부에서 넘어오는 값(인자, argument)를
        //현재 메소드 내에 저장하기 위해 선언하는 지역변수.
        //지역변수이기 때문에 메소드 실행 종료시 자동으로 사라짐.(증요)
        public Score(int kor, int eng, int mat) // 생성자 만든것.
        {
            Kor = kor;
            Eng = eng;
            Mat = mat;
        }
    }
}
