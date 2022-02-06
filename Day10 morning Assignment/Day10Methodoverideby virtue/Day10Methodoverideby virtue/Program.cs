using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Methodoverriding
{
    //****************************************************************\\
    //Author:Narala Praveen
    //Purpose:To do method overriding using Virtue and override keyword
    //*******************************************************************\\

    class SwiggyMessege
    {/// <summary>
     /// This Method is for Printing
     /// </summary>
        public void printHi()
        {
            Console.WriteLine("Hi");
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        public virtual void PrintEat()
        {
            Console.WriteLine("Eat");
        }
    }

    class ZomatoMessege : SwiggyMessege
    {

        public override void PrintEat()
        {
            Console.WriteLine("Tinavara");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ZomatoMessege obj = new ZomatoMessege();
            obj.PrintEat();
            Console.ReadLine();

        }
    }
}
