using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13project6
{
    //Author:Narala Praveen
    //Purpose:Product of Two matrices
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int m;
            int n;
            int p;
            int q;
            Console.WriteLine("Enter rows value of a:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter columns value of a:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rows value of b");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter columns value of b");
            q = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m,n];
            
            //for loop for A matrices
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine("Enter a matrices values ");
                        
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
   
                }
                Console.WriteLine();
            }

            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            //for loop for b Matrices
            int[,] b = new int[p, q];

            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.WriteLine("Enter b matrices values ");

                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }


            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            
                if(n==p)
            {  //product matrices
                int[,] c = new int[m, q];
                Console.WriteLine("Multiplication:");
                for(int i=0;i<m;i++)
                {
                    for(int j=0;j<q;j++)
                    {
                        c[i, j] = 0;
                        for(int k=0;k<n;k++)
                        {
                            c[i, j] += a[i, k] * b[k,j];
                        }
                        Console.Write(c[i,j]+" ");
                    }
                    Console.WriteLine("\n");
                }
            }

            Console.ReadLine();
        }
    }
}
