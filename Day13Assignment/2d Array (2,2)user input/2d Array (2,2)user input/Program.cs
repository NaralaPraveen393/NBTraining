using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_Array__2_2_user_input
{  //Author :Narala Praveen
    //Purpose:To declare a 2D array bu user input
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            
            //user input

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine("enter input at ={0}:", (i,j));
                    data[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            //output
            Console.WriteLine("The entered matrix is:");
            for(int i=0;i<2;i++)
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
