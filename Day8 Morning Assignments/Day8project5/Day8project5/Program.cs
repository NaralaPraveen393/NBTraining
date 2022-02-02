using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8project5
{         //**************************************************************\\
          //Author:Narala Praveen
          //Purpose:To create own class and variables and print using
          //For loop
          //For each loop
          //Lambda Expression
          //LINQ query
          //******************************************************************\\

    class Bike
    {
        public string name;
        public int price;
        public string model;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bike> bike = new List<Bike>
            {
                new Bike() {name= "Royal Enfield",price=200000,model="classic 350"},
                new Bike() {name = "Yamaha",price =170000, model = "R15"},
                new Bike() {name = "Suziki", price =150000, model = "Gixer"},
                new Bike() {name = "Kawasaki", price=400000, model = "Ninja"},
                new Bike() {name = "Hansverna" ,price=210000, model="Vtplaner"}
            };
            //For loop
            for(int i = 0;i<bike.Count;i++)
            {
                if (bike[i].price>=180000)
                    Console.WriteLine(bike[i].name+","+bike[i].model);
            }


            //For each loop
            foreach (var b in bike)
            {
                if (b.price >= 180000)
                    Console.WriteLine(b.name + "," + b.model);
            }
            //Lambda Expression
            bike.ToList().Where(b => b.price >= 180000).ToList().ForEach(b => Console.WriteLine(b.name+"-"+b.model));

            //Linq Query
            var result = from b in bike
                         where b.price>=180000
                         select b;
            result.ToList().ForEach(b => Console.WriteLine(b.name + "," + b.model));
              
            Console.ReadLine();
        }  
    }
}
