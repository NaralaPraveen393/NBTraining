using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project3
{  //Author:Narala Praveen
    //Purpose:To illustrate nullable types
    internal class Program
    {
        static void Main(string[] args)
        {
           Nullable <int> n = 20;

            if(n.HasValue)

            Console.WriteLine(n*n);
            else
                Console.WriteLine("no value");  
            Console.ReadLine();
        }
    }
}
