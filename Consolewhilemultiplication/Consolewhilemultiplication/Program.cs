using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolewhilemultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i = 1;

            Console.WriteLine("Enter number");
            input=Convert.ToInt32(Console.ReadLine());
            while(i<=10)
            {
                Console.WriteLine("{0}x{1}={2}", input, i, input * i);
                i++;
            }
          Console.ReadLine();
            
        }
    }
}
