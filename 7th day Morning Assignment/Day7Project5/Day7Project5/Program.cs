using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project5
{      //*********************************************************\\
       //Author:Narala Praveen
       //Purpose:To Create Employee class with Public Vaariables
       //**********************************************************\\
  class Employee
    {
        public string Name;
        public int ID;
        public int Salary;


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { ID = 101, Name = "Praveen", Salary = 25000 };
            

            Console.WriteLine($"ID={emp1.ID},Name={emp1.Name},Salary={emp1.Salary}");
            Console.ReadLine();

        }
    }
}
