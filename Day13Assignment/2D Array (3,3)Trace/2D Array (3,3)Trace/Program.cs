using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array__3_3_Trace
{   //Author:Narala Praveen
    //Purpose:To find the trace of 2D array
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialization of Array
            int sum = 0;
            int[,] data = new int[,] { { 5, 34, 28 }, { 52, 6, 28 }, { 72, 42, 3 } };
            Console.WriteLine("The trace of Mtrix is:");

            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if (i == j)//condition
                        sum = sum + data[i, j];
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
