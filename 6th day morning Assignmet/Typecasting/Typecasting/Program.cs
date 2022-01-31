using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Casting
            int a = 10;
            long b = a;
            Console.WriteLine(b);

            //Explicit Casting
            long c = 22;
            int d = (int)c;

            
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
