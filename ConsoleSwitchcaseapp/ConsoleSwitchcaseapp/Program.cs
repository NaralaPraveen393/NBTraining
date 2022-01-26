using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSwitchcaseapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            char input;

            //user input
            Console.WriteLine("Enter Your character");
            input = Convert.ToChar(Console.ReadLine());

            //Logic and output
            switch (input)
            {
                case 'a':

                case 'e':

                case 'i':

                case '0':

                case 'u':
                    Console.WriteLine("The given input is vowel");
                    break;
               default:
                    Console.WriteLine("The given input is Consonant");
                    break ;
            }
            Console.ReadLine();
        }
    }
}
