using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{    //Author:Narala Praveen
    //Purpose:Queue Example.
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(20);
            data.Enqueue(42);
            data.Enqueue(84);
            data.Enqueue(41);
            Console.WriteLine("before Dequeue");
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());
            Console.WriteLine("After Dequeue");
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
