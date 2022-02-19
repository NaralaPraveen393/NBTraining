using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project1
{  //Author:Narala Praveen
    //Purpose :Scope of Variables
     class ClassLevelscope
      //class scope starts
    {
       public static int a = 10;
       public static int b = 18;
        private static int sum = 0;
        
        //Method scope starts
        static void Main(string[] args)
        {
            
            sum = a + b;
            Console.WriteLine($"The sum is {sum}");
            Console.ReadLine();
        }//Method scope ends
    }//class scope ends
}
