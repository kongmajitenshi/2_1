using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj5
{
    internal class Team
    {
        public string Name; // 구단명
        public string Coach; // 감독명
        public int Level; // 순위
        public string Home; //연고지

        public string CurrentStatus
        {
            get
            {
                return $"{Name}은(는) 현재 가을야구 {(Level <= 5 ? "가능" : "불가능")}";
            }
        }
    }
}
