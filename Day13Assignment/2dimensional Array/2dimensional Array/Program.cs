using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Author:Narala Praveen
            //Purpose:Declare an 2d array of size(2,2)
            int[,] data = new int[2, 2];
            data[0, 0] = 8;
            data[0, 1] = 12;
            data[1, 0] = 28;
            data[1, 1] = 42;
            Console.WriteLine("The entered Matrix is=");
            for (int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(data[i,j]+" ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
