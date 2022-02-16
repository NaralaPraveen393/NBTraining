using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Project2
{  //Author:Narala Praveen
    //Purpose:Code for Factorial

    class Maths
    {
        public static int GetFactorial()
        {
            int input; int fact = 1;
            Console.WriteLine("Enter input");
            input = Convert.ToInt32(Console.ReadLine());
            
            
            for(int i =1;i<=input;i++)
                fact=fact*i;    
                return fact;
         
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Maths.GetFactorial());
            Console.ReadLine();
        }
    }
}
