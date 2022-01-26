using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input, product = 1, i;
            //User output
            Console.WriteLine("Enter any number");
            input=Convert.ToInt32(Console.ReadLine());
            //Logic
            for(i=1;i<=input;i++)
            { product = product * i; }
            //output
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
