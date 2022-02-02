using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8project2employees
{          //**************************************************************\\
            //Author:Narala Praveen
            //Purpose:To create a class with Employee with 3 Variables and Print using
            //for loop
            //for each
            //Lambda Expression
            //LINQ query
            //******************************************************************\\

class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee() { id = 101, name="Praveen",salary=25000},
                new Employee() { id =102, name="sairam", salary=35000},
                new Employee() { id = 103, name="Karthik",salary=45000},
                new Employee() { id = 104, name = "suresh",salary =55000},
                new Employee() { id =105, name= "Prasad", salary =65000},
            };
            //For loop
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"id={employees[i].id},name={employees[i].name},salary={employees[i].salary}");
            }

            //For each
            foreach (var e in employees)
            {
                Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
            }


            //Lambda Expression
            employees.ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));

            //LINQ query
            var result = from e in employees
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));

            Console.ReadLine();

        }
    }
}
