using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using publiclibrary;
using praveenLibrary;
namespace Clientapp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Final velocity\n{ Physics.FinalVelocity(6, 2, 6)}");
            Console.WriteLine($"Multiplication\n{Mathematics.Multiplication(2,6)}");
            Console.WriteLine($"Division\n{Mathematics.Divide(8,2)}");
            Console.ReadLine();
        }
    }
}
