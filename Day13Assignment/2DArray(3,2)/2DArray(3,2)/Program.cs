using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray_3_2_
{ //Author :Narala Praveen
  //Purpose:To declare 2D array of size(3,2) and initialise
    internal class Program
    {
        static void Main(string[] args)
        {
            //initializing of Array
            int[,] data = new int[,] { { 2, 6 },{ 3, 5 }, { 6, 9 } };
            Console.WriteLine("The enterd matrix is=");
            for(int i=0;i<3;i++)
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
