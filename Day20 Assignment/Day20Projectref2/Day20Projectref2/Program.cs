using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Projectref2
{  //Author:Narala Praveen
    //Purpose:To illustrate ref parameter
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            int j = 15;
            Console.WriteLine("initially i is {0}",i);
            Console.WriteLine("initially j is {0}", j);

            AddValue(  i);
            Console.WriteLine("value of i after addition operation is{0}",i);


            Subtract(ref j);
            Console.WriteLine("value of j after subtraction operation is {0}",j);

            Console.ReadLine();
        }
        public static void AddValue(  int i)
        {
            i += 12;
        }
        public static void Subtract(ref int j)
        {
            j -= 12;
        }
    }
}
