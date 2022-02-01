using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project8_CustomerAge
{          //*****************************************************\\
            //Author:Narala Praveen
            //Purpose:To Print customer age greater than 50
            //******************************************************\\
            class Customer
    {
        public string name;
        public int id;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer[] customers = new Customer[]
               {
            new Customer() { id = 101, name = "Praveen", age = 25},
            new Customer() { id = 102, name = "Rajesh", age = 35},
            new Customer() { id = 103, name = "Bhanu", age = 45},
            new Customer() { id = 104, name = "Mahesh", age = 55},
            new Customer() { id = 105, name = "Sairam", age = 65},
               };

            //For loop
            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i].age > 50)

                    Console.WriteLine($"ID={customers[i].id},Name={customers[i].name},Age={customers[i].age}");
            }
            //For each loop

            foreach (var c in customers)
            {
                if (c.age > 50)
                    Console.WriteLine($"Id={c.id},Name={c.name},Age={c.age}");
            }

            //Lambda Expression

            customers.ToList().Where(c => c.age >= 50).ToList().ForEach(e => Console.WriteLine($"ID={e.id},Name={e.name},Age={e.age}"));

            Console.ReadLine();
        }
    }
}
