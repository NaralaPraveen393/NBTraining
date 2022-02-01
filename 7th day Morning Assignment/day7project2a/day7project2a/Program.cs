using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7project2a
{
        //***************************************************\\
        //Author:Narala Praveen
        //Purpose:create class for customer
    class Customer
    {
        private string Name;
        private int ID;
        private int age;

        public void ReadCustomer()
        {
            Console.WriteLine("Enter Name:");
            Name= Console.ReadLine();

            Console.WriteLine("Enter ID:");
            ID=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age:");
            age= Convert.ToInt32(Console.ReadLine());   
        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Name={Name},ID={ID},Age={age}");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(); 
            Customer customer2 = new Customer();    

            customer1.ReadCustomer();
            customer2.ReadCustomer();

            customer1.PrintCustomer();
            customer2.PrintCustomer();

            Console.ReadLine();
        }
    }
}
