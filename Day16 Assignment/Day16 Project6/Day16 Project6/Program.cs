using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Project6
{ //Author :Narala Praveen
  //Purpose:Code for Multiplication table for a given number.

    class Multiplication
    {
        
        
            int n;
            public void ReadData()
            {
                Console.WriteLine("Enter number");
                n = Convert.ToInt32(Console.ReadLine());
            }
        public void GetMultiplication()
        { 
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine(n+"x"+i+"="+n*i);
                
            }
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             Multiplication m = new Multiplication();
            m.ReadData();
             m.GetMultiplication();
            Console.ReadLine();
        }
    }
}
