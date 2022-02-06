using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Abstract_Own_Example
{    //**************************************************************\\
    //Author:Narala Praveen
    //Purpose:To Create an Abstract class of own choice
    //****************************************************************\\

    abstract class Car
    {/// <summary>
     /// This method is for getting car metirial
     /// </summary>
     /// <param name="basic"></param>
     /// <returns></returns>
        public void  PrintMaterial(string iron)
        {
            Console.WriteLine("castiron");
        }
        /// <summary>
        /// this method is to get number of wheels
        /// </summary>
        /// <param name="basic"></param>
        /// <returns></returns>
        public int GetWheels(int n)
        {
            return 4 ;
        }
        /// <summary>
        /// This method to override model in derived class
        /// </summary>
        /// <returns></returns>
        public abstract void  GetModel();

        /// <summary>
        /// This method is to override price in derived class
        /// </summary>
        /// <returns></returns>
        public abstract int GetPrice();

    }
    class BMW : Car
    {
        public override void GetModel()
        {
            Console.WriteLine("BMWX3");
        }
        public override int GetPrice()
        {
            return 6500000;  
        }
    }
    class Audi: Car
    {
        public override void GetModel()
        {
            Console.WriteLine("AudiQ7");
        }
        public override int GetPrice()
        {
            return 7900000;
        }
    }
    class Mercedes : Car
    {
        public override void GetModel()
        {
            Console.WriteLine("Limousine");
        }
        public override int GetPrice()
        {
            return 5000000;
        }
    }
    class Toyota : Car
    {
        public override void GetModel()
        {
            Console.WriteLine("Vellfire");
        }
        public override int GetPrice()
        {
            return 8000000;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //BMW
            //Audi
            //Mercedes
            //Toyota
            Console.WriteLine("Comleted Processing");
            Console.ReadLine();
        }
    }
 }