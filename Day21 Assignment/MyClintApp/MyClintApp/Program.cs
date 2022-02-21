using MyClintApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClintApp
{ //Author:Narala Praveem
    //Purpose:To check the Web services methods 
    internal class Program
    {
        static void Main(string[] args)
        {
            PraveenNaralaserviceSoapClient pc = new PraveenNaralaserviceSoapClient();
            Console.WriteLine($"Factorial is{pc.Factorial(4)}");
            Console.WriteLine($"Addition is {pc.Add(6,8)}");
            Console.WriteLine($"Multiplication is {pc.Multiplication(5,6)}");
            Console.WriteLine($"Division is {pc.Division(8,6)}");
            Console.WriteLine($"Subtraction is {pc.Subtract(21,15)}");
            Console.ReadLine();


        }
    }
}
