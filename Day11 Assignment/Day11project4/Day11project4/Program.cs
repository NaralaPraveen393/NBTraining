using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project4
{ //Author:Narala Praveen
    //To create Mathematics class with 3 static methods and call in main method.

    class MatheMatics
    {
        public static int Add(int a ,int b)
        {
            return a+ b;
        }
        public static int sub(int a,int b)
        {
            return a-b;
        }
        public static int Multiplication(int a, int b)
        {
            return a*b; 
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MatheMatics math=new MatheMatics();
            Console.WriteLine($"Addition={MatheMatics.Add(5,6)}");
            Console.WriteLine($"Subtraction={MatheMatics.sub(8,4)}");
            Console.WriteLine($"Multiplication={MatheMatics.Multiplication(5,6)}");
            Console.ReadLine();

        }
    }
}
