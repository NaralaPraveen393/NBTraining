using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project2
{
    internal class Customer
    {
        private string name;
        private int ID;
        private int age;

        public void ReadCustomer()
        {
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter ID:");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());   
        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Name={name},ID={ID},Age={age}");
            
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
