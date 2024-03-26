namespace Proj7
{
    internal class Employee
    {
        public string Name;
        public string Number;
        public string Depart;
        public decimal Salary;

        public decimal MonthlySalary
        {
            get {
                return Salary / 12;
            }
        }
        public decimal GetMonthlySalary()
        {
            return Salary / 12;
        }
        public void ChangeSalary(double percent)
        {
            Salary *= (decimal)(1.0 + (percent / 100.0));
        }
    }
}