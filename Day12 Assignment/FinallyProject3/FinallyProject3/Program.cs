using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finallyproject3
//Author:Narala Praveen
//Purpose:example for finally block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we can write number of methods in "Try" 
            try
            {
                int a;
                int b;
                int c;

                Console.WriteLine("Enter first number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("division={0}", c);

            }
            //Exceptions:
            catch (OverflowException)
            {
                Console.WriteLine("The number entered out of range");

            }
            catch (FormatException)
            {
                Console.WriteLine("The entered input is in wrong format enter only numbers");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("The number can't be divide by zero");

            }
            catch (Exception)
            {
                Console.WriteLine("some error occured pleace contact @Praveencompany");
            }
            finally
            {
                Console.WriteLine("\n\n\n\n\n\nDesigned by @praveen");
                Console.ReadLine();
            }


        }
    }
}
