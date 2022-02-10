using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14project2
{      //**********************************************************************\\
       //Author:Narala Praveen
       //Purpose:Difference between normal Properties.

    class kineticenergy
    {
        private int energy;
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
        public int Energy
        { 
            get
            { 
                energy = (mass * velocity * velocity) / 2;
                return energy;
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
            Console.WriteLine($"Kinetic energy: {k.Energy}");
            Console.ReadLine();
        }
    }
}
