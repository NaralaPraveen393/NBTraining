using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14projec4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            
            
            Console.WriteLine("Enter any number");
            n = Convert.ToInt32(Console.ReadLine());

            for ( i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    break;
            }
                if (i == n)
                    Console.WriteLine("The number is prime");
                else
                    Console.WriteLine("the number is not prime");
            
            Console.ReadLine();
                

            
        }
    }
}
