using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project3products
{         //******************************************************************\\
          //Author:Narala Praveen
          //Purpose:To create a Product class and print products whose price>500
          //********************************************************************\\

    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
            {
                new Product() { id = 101, name="watch",price=250, brand="Fossil"},
                new Product() { id =102, name="cap", price=350, brand="CAP"},
                new Product() { id = 103, name="shoes",price=450, brand="Nike"},
                new Product() { id = 104, name = "belt",price =550, brand="Levis"},
                new Product() { id =105, name= "socks", price =650, brand="Puma"},
            };
            //For loop
            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].price>=500)
                Console.WriteLine($"name={products[i].name},brand={products[i].brand}");
            }

            //For each
            foreach (var p in products)
            {
                if(p.price>=500)
                Console.WriteLine($"name={p.name},brand={p.brand}");
            }


            //Lambda Expression
            products.ToList().Where(p=>p.price>=500).ToList().ForEach(p => Console.WriteLine($"name={p.name},brand={p.brand}"));

            //LINQ query
            var result = from p in products
                         where p.price >500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"name={p.name},brand={p.brand}"));

            Console.ReadLine();
        }
    }
}
