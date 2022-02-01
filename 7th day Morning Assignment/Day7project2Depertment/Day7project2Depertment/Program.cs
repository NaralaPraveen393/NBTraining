using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project2Depertment
{                  //********************************************\\
                     //Author :Narala Praveen//
                     //Purpose:To create Department Class//
                //*************************************************\\
   class Department
    {
        private string Name;
        private int Number;
        private string Description;

        public void ReadDepartment()
        {
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Department number:");
            Number= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Description:");
            Description = Console.ReadLine();   
        }
        public void PrintDepartment()
        {
            Console.WriteLine($"Name={Name},Number={Number},Description={Description}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department1 = new Department(); 
            Department department2 = new Department();

            department1.ReadDepartment();
            department2.ReadDepartment();

            department1.PrintDepartment();
            department2.PrintDepartment();

            Console.ReadLine(); 

         


        }
    }
}
