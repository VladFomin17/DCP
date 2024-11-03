using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid1
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double BaseSalary { get; set; }

        public Employee(string employeeID, string employeeName, double baseSalary)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            BaseSalary = baseSalary;
        }

        public void getInfo()
        {
            Console.WriteLine($"ID сотрудника: {EmployeeID}");
            Console.WriteLine($"Имя сотрудника: {EmployeeName}");
            Console.WriteLine($"Оклад сотрудника: {BaseSalary}");
        }
    }
}
