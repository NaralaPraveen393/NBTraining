using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project3
{       //**********************************************\\
        //Author:Narala Praveen
        //Purpose:To create a employee class and print data
        //**********************************************\\

    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";

     public void ReadData()
        {
            Console.WriteLine("Enter Employee id:");
            id=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Employee Name");
            name=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            salary=Convert.ToInt32(Console.ReadLine());

            
        }
        public void PrintData()
        {
            Console.WriteLine($"Id :{id},Name:{name},Salary:{salary},Company={company}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadData();
            emp1.PrintData();

            Employee emp2 = new Employee();
            emp2.ReadData();
            emp2.PrintData();


            Console.ReadLine();
        }
    }
}
