using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7dayMorningproject1
{
    //*******************************************************************\\
    //Author:Narala Praveen
    //Purpose:To Create Employee class with three variables and two methods
    //Read Employee and PrintEmployee And Create an object and call methods
    //*******************************************************************\\
    class Employee
    {
        private int Id;
        private string Name;
        private int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("Enter Id:");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Emplyee name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Id={Id},Name={Name},Salary={salary}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp1.ReadEmployee();
            emp2.ReadEmployee();
            emp3.ReadEmployee();

            emp1.PrintEmployee();
            emp2.PrintEmployee();
            emp3.PrintEmployee();

            Console.ReadLine();
        }
    }
}
