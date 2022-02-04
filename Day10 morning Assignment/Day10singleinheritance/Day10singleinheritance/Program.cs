using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10singleinheritance
{ 
    //******************************************************************\\
    //Author:Narala Praveen
    //Purpose:Simple Code for Single inheritance
    //*******************************************************************\\

    class Algebra
    {
        /// <summary>
        /// This method is for Addition
        /// </summary>
        /// <returns></returns>
        public int Add(int a ,int b)
        {
            return a + b;   
        }

    }
    class Substract:Algebra
    {
        /// <summary>
        /// This method SubStract
        /// </summary>
        /// <returns></returns>
        public int Sub(int a ,int b)
        {
            return a - b;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Substract obj= new Substract();
            Console.WriteLine(obj.Add(5,4));
            Console.WriteLine(obj.Sub(6,2));

            Console.ReadLine();
        }
    }
}
