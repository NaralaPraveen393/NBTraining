using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14project5
{   //Author:Narala Praveen
    //Purpose:print numbers which are not divisble by 3 in the range of 1 to 30
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=1;i<30;i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);

            }
            Console.ReadLine();
        }
    }
}
