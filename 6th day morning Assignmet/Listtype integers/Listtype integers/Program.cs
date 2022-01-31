using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listtype_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1=0; int sum2=0;int sum3=0;
            //Read data from User
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter any number");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }
            //sum using For loop
            for(int i = 0; i<data.Count;i++)
            {
                sum1 = sum1 + data[i];
            }
            //sum using For each
            foreach(var d in data)
            {
                sum2 = sum2 + d;
            }
            //sum using Lambda expression
            data.ForEach(v => sum3 = sum3 + v);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.ReadLine();
        }
    }
}
