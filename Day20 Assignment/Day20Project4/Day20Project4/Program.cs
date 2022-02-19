using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project4
{  //Author:Narala Praveen
    //Purpose:To illustrate out and ref parameters
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k;
            Multiplication(out i, out j, out k); ;
            Console.WriteLine("First number   is {0}",i);
            Console.WriteLine("second number is {0}", j);
            Console.WriteLine("product is {0}", k);
            Console.ReadLine();
        }
        public static void Multiplication(out int i,out int j,out int k)
        {
            i = 10;
            j=4;
            k = i * j;
        }
        
    }
}
