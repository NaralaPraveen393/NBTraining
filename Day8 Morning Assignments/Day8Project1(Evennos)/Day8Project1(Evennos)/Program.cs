using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project1_Evennos_
{     //*****************************************************************************\\
       //Author:Narala Praveen
       //Purpose:To Declare and initialize a list with 8 values and print even numbers
       //****************************************************************************\\
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 28, 44, 85, 56, 65, 72, 55, 95, 104 };

            //For loop
            for(int i = 0; i < data.Count; i++)
            {
                if(data[i]%2==0)

                    Console.WriteLine(data[i]);
            }
            //For each loop
            foreach(var d in data)
            {
                if(d%2==0)
                    Console.WriteLine(d);
            }
            //Lambda Expression
            data.ToList().Where(d => d%2==0).ToList().ForEach(d => Console.WriteLine(d));

            //LINQ Query
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();

        }
    }
}
