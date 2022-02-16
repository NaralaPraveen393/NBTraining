using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths;

namespace Day8Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The factorial of 4 {Algebra.Factorial(4)}");
            Console.WriteLine($"The factorial of 0 is {Algebra.Factorial(0)}");
            Console.WriteLine($"The factorial of 8 is {Algebra.Factorial(8)}");
            Console.WriteLine($"The factorial of -1 is{Algebra.Factorial(-1)}");
            Console.WriteLine(Algebra.Palindrome(363));
            Console.ReadLine();
        }
    }
}
