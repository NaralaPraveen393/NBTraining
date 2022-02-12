using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           File.Copy("C:\\NBHtraining\\Day14 Assignment\\Day15project1\\folder1\\Praveen.txt", "C:\\NBHtraining\\Day14 Assignment\\Day15project1\\folder2\\Praveen.txt");
            Console.WriteLine("File Has been Copied");
            Console.ReadLine();
        }
    }
}
