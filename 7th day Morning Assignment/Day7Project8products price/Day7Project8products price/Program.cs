using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project8products_price
{        //*************************************************\\
         //Author:Narala Praveen
         //Purpose:to print the products whose price is greater and equal to 50
         class Product
    {
        public string name;
        public int price;
        public string colour;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Product[] products = new Product[]
               {
            new Product() { colour = "black", name = "sanitizer", price = 25},
            new Product() { colour = "pink", name = "mask", price = 35},
            new Product() { colour = "red", name = "mouth fresher", price = 45},
            new Product() { colour = "white", name = "sheild", price = 55},
            new Product() { colour = "orange", name = "gloves", price = 65},
               };

            //For loop
            for (int i = 0; i < products.Length; i++)
            {
                if(products[i].price>=50)

                Console.WriteLine($"Colour={products[i].colour},Name={products[i].name},price={products[i].price}");
            }
            //For each loop

            foreach (var p in products)
            {
                if(p.price>=50) 
                Console.WriteLine($"colour={p.colour},Name={p.name},price={p.price}");
            }

            //Lambda Expression

            products.ToList().Where(p=>p.price>=50).ToList().ForEach(p => Console.WriteLine($"colour={p.colour},Name={p.name},price={p.price}"));

            Console.ReadLine();
        }
    }
}
