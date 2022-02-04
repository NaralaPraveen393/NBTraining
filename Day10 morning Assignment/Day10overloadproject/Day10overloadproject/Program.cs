using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10overloadproject
{         //****************************************************************\\
          //Author:Narala Praveen
          //Purpose:To create class and perform method overload
          //*****************************************************************\\

    class Mathstask
    {
        /// <summary>
        /// This method performs Addition
        /// </summary>
        /// <returns></returns>
        public int Add(int a,int b)
        {
            return a + b;   
        }

        public int Add(int a,int b, int c)
        {
            return a + b +c;    
        }

        public int Add(int a, int b, int c,int d)
        { 
            return a + b +c +d;
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathstask obj = new Mathstask();
            Console.WriteLine(obj.Add(5, 2));
            Console.WriteLine(obj.Add(5,2,3));
            Console.WriteLine(obj.Add(5,2,3,4));

            Console.ReadLine();

        }
    }
}
