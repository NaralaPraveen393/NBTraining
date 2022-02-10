using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14project2auto
{      //**********************************************************************\\
       //Author:Narala Praveen
       //Purpose:code for Auto-implemented Properties.

    class kineticenergy
    {
        
        private int mass;
        private int velocity;

        //Normal Properties.
        public int Mass
        {

            set { mass = value; }
        }
        public int Velocity
        {

            set { velocity = value; }

        }
        //Auto-implemented properties:
        public int Energy
        {
            get
            {
                return  (mass * velocity * velocity) / 2;
                
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            kineticenergy k = new kineticenergy();
            k.Mass = 20;
            k.Velocity = 12;
            Console.WriteLine($"Auto implemented Kinetic energy: {k.Energy}");
            Console.ReadLine();
        }
    }
}
