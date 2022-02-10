using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_Array
{  //Author:narala Praveen
    //Purpose:Jagged Array
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0] = new char[] { 's', 'a', 'i' };
            names[1] = new char[] { 'r', 'a', 'j', 'u' };
            names[2] = new char[] { 'p', 'r', 'a', 'v', 'e', 'e', 'n' };
            
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<names[i].Length;j++)
                {
                    Console.Write(names[i][j] +" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
