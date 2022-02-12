using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15project3
{
    internal class Program
    {
        public static object Day15project1 { get; private set; }

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\NBHtraining\\Day14 Assignment\\Day15project1\\folder1\\Praveen.txt",true);
            sw.WriteLine("Hi");
            sw.WriteLine("These is praveen");
            sw.WriteLine("File has created");
            sw.Close();
            Console.WriteLine("File done");
            Console.ReadLine();

        }
    }
}
