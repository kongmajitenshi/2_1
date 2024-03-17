using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj4
{
    public class Member
    {
        public string Name;
        public int Age;
        public bool IsRegular;

        public string Status
        {
            get
            {
                // $"{Name}회원은 {IsRegular ? "정회원":"준회원"}입니다."
                return $"{Name} 회원은 {(IsRegular ? "정회원":"준회원")}입니다.";
            }
        }
    }
}
