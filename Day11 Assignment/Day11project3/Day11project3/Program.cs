using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project3
{    //Author:Narala praveen.
    //Purpose:Employee class with only properties.
    class Employee
    {
        
        

        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = 101;
            }
        }
        public string Name
        {
            get { return Name; }
            set { Name = "Praveen"; }
        }
        public string Designation
        {
            get { return Designation; }
            set { Designation = value; }
        }

        public int Salary
        {
            get { return (Designation == "S") ? 30000 : 500000; }
         }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
                emp.Designation = "S";
            Console.WriteLine($"Salary={emp.Salary}");

            Console.ReadLine();
        }
    }
}
