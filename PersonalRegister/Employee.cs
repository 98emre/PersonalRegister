using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public class Employee
    {
        private string name;
        private int salary;

        public Employee(string name, int salary) { 
            this.name = name;
            this.salary = salary;   
        }   

        public void setName(string name) { 
            this.name = name;
        }

        public string getName() { 
            return this.name;
        }

        public void setSalary(int salary){   
            this.salary = salary;
        }

        public int getSalary() { 
            return this.salary;
        }

        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.name);
            sb.Append(" ");
            sb.Append(this.salary);

            return sb.ToString();
        }

    }
}
