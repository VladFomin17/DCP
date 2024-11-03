using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid1
{
    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee, double bonusPercentage)
        {
            double bonus = employee.BaseSalary * bonusPercentage / 100;

            return employee.BaseSalary + bonus;
        }
    }
}
