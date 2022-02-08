using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionproject1
    //Author:Narala Praveen
    //Purpose:To write a simple division program  with three exceptions
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
                Console.ReadLine();
                
            }
            //Exceptions:
            catch (OverflowException)
            {
                Console.WriteLine("The number entered out of range");
                Console.ReadLine();
               
            }
            catch (FormatException)
            {
                Console.WriteLine("The entered input is in wrong format enter only numbers");
                Console.ReadLine();
              
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("The number can't be divide by zero");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("some error occured pleace contact ");
                Console.ReadLine();
            }
        }
    }
}
