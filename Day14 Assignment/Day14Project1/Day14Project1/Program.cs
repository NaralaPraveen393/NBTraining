using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project1
{            //******************************************************\\
             //Author:Narala Praveen
             //Purpose:To create an Sealed class.

    /// <summary>
    /// sealed class
    /// </summary>
   sealed class  Bike
    {
        public int price;
        public string name;
    }
    /// <summary>
    /// not possible to inherit.
    /// </summary>
    class Car:Bike
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.price = 5000;
            bike.name = "yamaha";
            Car car = new Car();
            car.price = 6000;
            Console.WriteLine(bike.price);
            Console.ReadLine();
        }
        
    }
}
