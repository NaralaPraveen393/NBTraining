using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7project2
{          //************************************************\\
             //Author :Narala Praveen
             //Purpose:Creating Product class
          //**************************************************\\
    class Product
    {
        private string Name;
        private int price;
        private string colour;

        public void ReadProduct()
        {
            Console.WriteLine("Enter Product name:");
            Name= Console.ReadLine();

            Console.WriteLine("Enter Product Price");
            price= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product colour");
            colour= Console.ReadLine(); 


        }
        public void PrintProduct()
        {
            Console.WriteLine($"Name={Name},Price={price},Colour={colour}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Product p1= new Product();
            Product p2= new Product();  
            Product p3= new Product();

            p1.ReadProduct();
            p2.ReadProduct();
            p3.ReadProduct();

            p1.PrintProduct();
            p2.PrintProduct();
            p3.PrintProduct();

            Console.ReadLine();
        }
    }
}
