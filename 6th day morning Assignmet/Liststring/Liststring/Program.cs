using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liststring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("Praveen");
            data.Add("Sai");
            data.Add("Kranthi");
            data.Add("Rishi");
            data.Add("Ayaansh");

            //print value using For loop
            for(int i=0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]);
            }
            //print value using For each
            foreach(var d in data)
            {
                Console.WriteLine(d);
            }

            //print value using Lambda Expression
            data.ForEach(v => Console.WriteLine(v));



            Console.ReadLine();
        }
    }
}
