using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraveenLibrary
{
    public class Mathematics
    {
        public static int GetFactorial()
        {
            int input;
            int fact = 1;
            Console.WriteLine("Enter number");
            input=Convert.ToInt32(Console.ReadLine());
            for(int i =1;i<=input;i++)  
                fact=fact*i;
            return fact;
        }
        public static int Add(int a,int b)
        {
            return a+b;
        }
        public static int Multiplication(int a,int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }

    }
}
