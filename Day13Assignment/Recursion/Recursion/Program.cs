using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{  //Author:Narala Praveen.
    //Purpose:Recursion example
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

                
            else
            {

                int fact = n * Factorial(n - 1);
                return fact;

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(n));
            Console.ReadLine();
        }
    }
}
