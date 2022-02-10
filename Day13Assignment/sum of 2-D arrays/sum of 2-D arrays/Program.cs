using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_2_D_arrays
{    //Author:Narala Praveen
    //Purpose:To perform sum of two arrays of size(2,2)
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] sum = new int[2, 2];
            //matrices one
            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("enter a values:");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            //matrices two
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter b values:");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            //Addition
            Console.WriteLine("After addition matrix is :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                    Console.Write(sum[i, j]+" ");

                }
               
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
