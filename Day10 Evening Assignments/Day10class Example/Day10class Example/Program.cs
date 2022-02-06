using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10class_Example
{    //**************************************************************\\
    //Author:Narala Praveen
    //Purpose:To Create an Abstract class.
    //****************************************************************\\

    abstract class Salary
    {/// <summary>
    /// This method is for getting PF
    /// </summary>
    /// <param name="basic"></param>
    /// <returns></returns>
        public int GetPF(int basic)
        {
            return 12 * basic / 100;
        }
        /// <summary>
        /// this method is to get HRA
        /// </summary>
        /// <param name="basic"></param>
        /// <returns></returns>
        public int GetHRA(int basic)
        {
            return 40 * basic / 100;    
        }
        /// <summary>
        /// This method to override Convience allowance in derived class
        /// </summary>
        /// <returns></returns>
        public abstract int GetCA();

        /// <summary>
        /// This method is to override Special allowance in derived class
        /// </summary>
        /// <returns></returns>
        public abstract int GetSA();

    }
    class MicroSoft:Salary
    {
        public override int GetCA()
        {
            return 6000;
        }
        public override int GetSA()
        {
            return 7000;
        }
    }
    class Google : Salary
    {
        public override int GetCA()
        {
            return 100000;
        }
        public override int GetSA()
        {
            return 10000;
        }
    }
    class IBM:Salary
    {
        public override int GetCA()
        {
            return 4000;
        }
        public override int GetSA()
        {
            return 6000;
        }
    }
    class Facebook:Salary
    {
        public override int GetCA()
        {
            return 20000;
        }
        public override int GetSA()
        {
            return 8000;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MicroSoft
            //Google
            //IBM
            //Facebook
            Console.WriteLine("Comleted Processing");
            Console.ReadLine();
        }
    }
}
