using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraysum_av
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int sum = 0, avg;
            int[] data = new int[5];

            //user input
            for(int i=0;i<data.Length;i++)
            {
                Console.WriteLine("Enter Number");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int p in data)
            {
                sum=sum+p;
            }
            avg= sum/data.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadLine();


        }
    }
}
