using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockleveScope
{
     class BlockLevelscope
    {
        

        static void Main(string[] args)
        {
            
            for ( int i = 0; i <= 5; i++) ;// int i scope is with in the for block
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
