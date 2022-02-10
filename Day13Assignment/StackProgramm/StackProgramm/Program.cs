using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProgramm
{    //Author:Narala Praveen
    //Purpose:Stack programm
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(20);
            data.Push(42);
            data.Push(84);
            data.Push(41);
            Console.WriteLine("before pop");
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());
            Console.WriteLine("After pop");
            Console.WriteLine(data.Count);

            Console.WriteLine("\n");
            Console.WriteLine("peek:");
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Count);

            Console.ReadLine();

        }
    }
}
