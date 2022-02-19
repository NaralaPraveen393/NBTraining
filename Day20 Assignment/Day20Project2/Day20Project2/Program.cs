using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project2
{  //Author :Narala Praveen
    //Purpose:code for delegates

    public delegate void myfact(int n);
        

    internal class Program
    {
        /// <summary>
        /// This method is used for finding factorial
        /// </summary>
        /// <param name="n"></param>
        public static void Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            
                fact *= i;
                Console.WriteLine(fact);
            
              
        }
        /// <summary>
        /// This  method is used for finding factors
        /// </summary>
        /// <param name="n"></param>
        public static void Factors(int n)
        {
            
            for (int i=1;i<=n;i++)
            {
                
                if(n%i==0)
             
                    Console.WriteLine(i);
            }      
        }
       
        static void Main(string[] args)
        {
            myfact mf = new myfact(Factorial);
            mf += Factors;
            mf(5);//Delegate
            mf(6);
            
            Console.ReadLine();
        }
    }
}
