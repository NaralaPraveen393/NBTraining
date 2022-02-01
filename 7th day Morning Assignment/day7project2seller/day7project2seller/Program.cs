using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7project2seller
{
        //**********************************************\\
        //Author:Narala Praveen
        //Purpose: To create Seller class
        //*********************************************\\
        class Seller
    {
        private int ID;
        private string Name;
        private string Brand;

        public void ReadSeller()
        {
            Console.WriteLine("Enter ID:");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Name:");
            Name= Console.ReadLine();

            Console.WriteLine("Enter Brand");
            Brand= Console.ReadLine();


        }
        public void PrintSeller()
        {
            Console.WriteLine($"ID={ID},Name={Name},Brand={Brand}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Seller seller1 = new Seller();
            Seller seller2 = new Seller();
            seller1.ReadSeller();   
            seller2.ReadSeller();

            seller1.PrintSeller();
            seller2.PrintSeller();

            Console.ReadLine();
        }
    }
}
