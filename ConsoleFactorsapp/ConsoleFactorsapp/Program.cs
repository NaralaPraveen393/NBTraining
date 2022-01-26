using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactorsapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input, i;

            //Read input from user
            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());

            //logic
            for (i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        
    }
}
