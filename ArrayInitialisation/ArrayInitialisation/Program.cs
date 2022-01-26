using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitialisation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable initialisation
            int sum = 0, p;
            int[] data = new int[] { 4, 9, 14, 16, 6, 7 };
            foreach(int i in data)
            {
                sum+=i;
            }
            p= sum/6;
            Console.WriteLine("The sum is "+sum);
            Console.WriteLine("Average is "+p);
            Console.ReadLine();
        }
    }
}
