using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTablesapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
          
            int input, i;

            //user input
            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());

            //Logic and output
            for (i = 1; i <= 10; i++)

            { Console.WriteLine(input + "x" + i + "=" + input * i); }

             for (i = 1; i<=10; i++)

            { Console.WriteLine("{0}x{1}={2}", input, i, input * i); }

            Console.ReadLine();
        }
    }
}
