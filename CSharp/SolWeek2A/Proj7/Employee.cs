using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj7
{
    public class Employee
    {
        public string Name; // 직원이름
        public string Number; // 사원번호
        public string Depart; // 부서이름
        public decimal Salary; // 연봉

        public decimal MonthlySalary
        {
            get
            {
                return Salary / 12;
            }
        }
    }
}
