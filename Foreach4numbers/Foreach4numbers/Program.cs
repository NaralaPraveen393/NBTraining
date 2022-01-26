using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach4numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int[] data = new int[4];
            // User input
            for(int i = 0; i < data.Length;i++)
            {
                Console.WriteLine("Enter number");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The numbers you entered are:");
            foreach (int i in data)
                Console.WriteLine(i);   
            Console.ReadLine();
        }
    }
}
