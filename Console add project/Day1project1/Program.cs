using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int fn, sn, sum = 0;

            fn = 80;
            
            Console.WriteLine("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            sum = fn + sn;

            Console.WriteLine("sum ="+sum);

            Console.ReadLine();
        }
    }
}
