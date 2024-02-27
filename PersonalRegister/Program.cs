using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            RegisterEmployee registerEmployee = new RegisterEmployee();

            while (true)
            {
                Console.WriteLine("\nChoose an option: ");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Print Register");
                Console.WriteLine("3. Remove Employee");
                Console.WriteLine("4. Exit");
                Console.Write("Input: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice) { 
                    case 1:
                        Console.Write("\nEnter employee name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter salary of the employee: ");

                        int salary;

                        if (!int.TryParse(Console.ReadLine(), out salary))
                        {
                            Console.WriteLine("Invalid salary. Please enter a valid number.");
                            continue;
                        }
                        registerEmployee.AddEmployee(name, salary);
                        break;

                    case 2:
                        registerEmployee.PrintAll();
                        break;

                    case 3:
                        Console.Write("\nEnter employee name, who you want to remove: ");
                        registerEmployee.RemoveEmployee(Console.ReadLine());
                        break;

                    case 4:
                        return;


                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }

        }
    }
}
