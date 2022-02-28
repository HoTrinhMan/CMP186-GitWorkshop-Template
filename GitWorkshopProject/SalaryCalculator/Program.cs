using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineerSalary = EmployeeService.CalculateSalary(EmployeeType.Engineer, 2);
            Console.WriteLine(string.Format("Engineer's Salary: {0}", engineerSalary));
            
           var expertSalary = EmployeeService.CalculateSalary(EmployeeType.Expert, 9);
            Console.WriteLine(string.Format("Expert's Salary: {0}", expertSalary)););

            Console.ReadLine();
        }
    }
}
