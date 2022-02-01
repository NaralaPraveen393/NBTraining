using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project7
{             //*****************************************\\
               //Author:Narala Praveen
               //Purpose:To print employess whose salary equal and morethan 50000
               //***********************************************\\
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
            Employee[] employees = new Employee[]
               {
            new Employee() { id = 101, name = "Praveen", salary = 25000 },
            new Employee() { id = 102, name = "Rajesh", salary = 35000 },
            new Employee() { id = 103, name = "Bhanu", salary = 45000 },
            new Employee() { id = 104, name = "Mahesh", salary = 55000 },
            new Employee() { id = 105, name = "Sairam", salary = 65000 },
               };

            //For loop
            for (int i = 0; i < employees.Length; i++)
            {
                if(employees[i].salary>=50000)

                Console.WriteLine($"ID={employees[i].id},Name={employees[i].name},Salary={employees[i].salary}");
            }
            //For each loop

            foreach (var e in employees)
            {
                if(e.salary>=50000)
                Console.WriteLine($"Id={e.id},Name={e.name},Salary={e.salary}");
            }

            //Lambda Expression

            employees.ToList().Where(e=>e.salary>=50000).ToList().ForEach(e => Console.WriteLine($"ID={e.id},Name={e.name},Salary={e.salary}"));

            Console.ReadLine();
        }
    }
}
