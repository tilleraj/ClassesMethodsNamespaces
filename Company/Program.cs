using System;
using System.Collections.Generic;

namespace Company
{
    class Program
    {
        public class Company
        {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees
            public List<Employee> Employees { get; set; } = new List<Employee> { };

            // Create a method that allows external code to add an employee
            public void addEmployee(Employee employeeToAdd)
            {
                Employees.Add(employeeToAdd);
            }

            // Create a method that allows external code to remove an employee
            public void removeEmployee(Employee employeeToRemove)
            {
                Employees.Remove(employeeToRemove);
            }

            public void ListEmployees()
            {
                foreach (Employee currentEmployee in Employees)
                {
                    Console.WriteLine(currentEmployee.Name);
                }
            }

            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
            public Company(string companyName, DateTime dateFounded)
            {
                Name = companyName;
                CreatedOn = dateFounded;
            }
        }
        static void Main(string[] args)
        {
            Company Nissan = new Company("Nissan", new DateTime(2008, 10, 20));

            Employee employee01 = new Employee("Jeff", JobTitle.Employee, new DateTime(2009, 01, 01));
            Employee employee02 = new Employee("Jose", JobTitle.Manager, new DateTime(2010, 02, 02));
            Employee employee03 = new Employee("Jimmy", JobTitle.Supervisor, new DateTime(2011, 03, 03));

            Nissan.addEmployee(employee01);
            Nissan.addEmployee(employee02);
            Nissan.addEmployee(employee03);

            Nissan.ListEmployees();
        }
    }
}
