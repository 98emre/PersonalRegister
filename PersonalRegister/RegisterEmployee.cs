using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public class RegisterEmployee
    {
        private Dictionary<string,Employee> employees;

        public RegisterEmployee() {
            this.employees = new Dictionary<string, Employee>();
        }

        public void AddEmployee(string name, int salary)
        {
            string trimmedName = name.Trim().ToLower();

            if (employees.ContainsKey(trimmedName))
            {
                Console.WriteLine("Employee: " + trimmedName + " already exist, try again");
                return;
            }

            employees.Add(trimmedName, new Employee(trimmedName, salary));

        }

        public void PrintAll()
        {
            Console.WriteLine("Employees");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            if(employees.Count == 0)
            {
                Console.WriteLine("There is no employees in ");
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Value.getName()}, Salary: {employee.Value.getSalary()}");
            }
        }

        public void RemoveEmployee(string name)
        {
            string trimmedName = name.Trim().ToLower();

            if(!employees.ContainsKey(trimmedName))
            {
                Console.WriteLine("Should not find the employee");
            }

            employees.Remove(name);
        }
    }
}
