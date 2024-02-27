using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public class RegisterEmployee
    {
        private List<Employee> employees;

        public RegisterEmployee() { 
            this.employees = new List<Employee>();
        }

        public void AddEmployee(string name, int salary)
        {
            employees.Add(new Employee(name, salary));
        }

        public void PrintAll()
        {
            Console.WriteLine("Employees");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            if(employees.Count == 0)
            {
                Console.WriteLine("There is no employees in the list");
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.getName()}, Salary: {employee.getSalary()}");
            }
        }
    }
}
