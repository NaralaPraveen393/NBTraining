using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodscope
{
     class MethodLevelscope
    { 
        public void Display()
        {
            int i = 10;
            Console.WriteLine(i);//with in method declared and accepted in side it
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            MethodLevelscope ml = new MethodLevelscope();
            ml.Display();
           
        }
    }
}
