using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Multilevelinheritance
{
    //******************************************************************\\
    //Author:Narala Praveen
    //Purpose:Simple Code for Multilevel inheritance
    //*******************************************************************\\

    class Algebra
    {
        /// <summary>
        /// This method is for Addition
        /// </summary>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

    }
    class Substract : Algebra
    {
        /// <summary>
        /// This method SubStract
        /// </summary>
        /// <returns></returns>
        public int Sub(int a, int b)
        {
            return a - b;
        }

    }
    class Product:Substract
    {
        /// <summary>
        /// This Method is for Multiplication
        /// </summary>
        /// <returns></returns>
        public int Multiplication(int a,int b)
        {
            return a * b;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Product obj = new Product();
            Console.WriteLine($"Add={obj.Add(5, 4)}");
            Console.WriteLine($"Sub={obj.Sub(6, 2)}");
            Console.WriteLine($"product={obj.Multiplication(5,3)}");

            Console.ReadLine();
        }
    }
}
