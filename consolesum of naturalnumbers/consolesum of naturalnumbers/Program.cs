using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolesum_of_naturalnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int input, sum = 0, i;
            //User input
            Console.WriteLine("enter any number");
            input=Convert.ToInt32(Console.ReadLine());
            //Logic
            for(i=1;i<=input;i++)
            { sum = sum + i; }
            //print output
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
