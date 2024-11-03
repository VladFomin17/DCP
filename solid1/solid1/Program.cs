using System;

namespace solid1
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("001", "Roman Peskov", 1400);
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            double EmloyeeSalary = salaryCalculator.CalculateSalary(employee, 6.29);
            Console.WriteLine($"Общая зарплата {employee.EmployeeName}: {EmloyeeSalary}");

        }
    }
}
