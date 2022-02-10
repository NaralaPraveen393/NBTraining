using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14project6
{     //*********************************************************\\
     //Author:Narala Praveen
     //Purpose:print the number which is divisible by 97 after 1000

    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 97;
            for(i=1000;i<1097;i++)
            {
                if (i % n== 0)
                    break;
            }
            Console.WriteLine("The number divisible by 97 is {0}",i);
            Console.ReadLine();
        }
    }
}
