using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16project7
{  //Author:Narala Praveen
    //Purpose:Code for Pallidrome

    class Pallindrome
    {
        public int n;
        public int rem;
        public int rev;
        public int temp;

        public void ReadData()
        {
           
            Console.WriteLine("Enter number");
            n=Convert.ToInt32(Console.ReadLine());   
        }
        public void GetPallindrome()
        {
            temp = n;
            while(n >0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                
                n = n / 10;
            }
            if (temp==rev)
            
                Console.WriteLine("The number  is pallindrome");
            
            else

                Console.WriteLine("The number is not Pallindrome");
            
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pallindrome p=new Pallindrome();
            p.ReadData();
            p.GetPallindrome();
            Console.ReadLine();

        }
    }
}
