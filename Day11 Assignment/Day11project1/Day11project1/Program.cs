using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11project1
{    //***************************************************************\\
    //Author:Narala Praveen
    //Purpose:To create a program for Interface
    //*****************************************************************\\

    interface IShape
    {
        /// <summary>
        /// This method is for Area
        /// </summary>
        /// <returns></returns>
        int Area();

        /// <summary>
        /// This method is for Perimeter
        /// </summary>
        /// <returns></returns>
        int Perimeter();
       
    }
    class Circle : IShape
    {
        public int radius;
        public void Readradius()
        {
            Console.WriteLine("Enter radius of circle");
            radius=Convert.ToInt32(Console.ReadLine());
        }
        public int Area()
        {
            return (22 * radius * radius )/ 7;
        }
        public int Perimeter()
        {
            return (2 * 22 * radius) / 7;
        }
    }
    class Reactangle : IShape
    {
        public int Length;
        public int Breadth;
        public void Readdata()
        {
            Console.WriteLine("Enter Length of Rectangle");
            Length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Reactangle");
            Breadth=Convert.ToInt32(Console.ReadLine());
        }
        public int Area()
        {
            return Length*Breadth;
        }
        public int Perimeter()
        {
            return 2 * (Length+Breadth);
        }

    }
    class Square:IShape
    {
        public int side;
        public void Readdata()
        {
            Console.WriteLine("Enter side of Square");
            side=Convert.ToInt32(Console.ReadLine());   
        }
        public int Area()
        {
            return side * side;
        }
        public int Perimeter()
        {
            return 4 * side;
        }
    }
    class Triangle:IShape
    {
        public int a;
        public int b;
        public int c;
        public int s;
        
        public void Readdata()
        {
            Console.WriteLine("Enter a of Triangle ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b of Triangle ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c of the Triangle");
            c=Convert.ToInt32(Console.ReadLine());  
            s=(a+b+c)/2;
        }
        public int Area()
        {
            return (int)(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));//Standard formula
        }
        public int Perimeter()
        {
            return a+b+c;   
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Readradius();
            Console.WriteLine($"Area of circle={c.Area()}");
            Console.WriteLine($"Perimeter of circle={c.Perimeter()}");

            Reactangle r=new Reactangle();
            r.Readdata();
            Console.WriteLine($"Area of Rectangle={r.Area()}");
            Console.WriteLine($"Perimeter of Rectangle={c.Perimeter()}");

            Square s =new Square();
            s.Readdata();
            Console.WriteLine($"Area of Square={s.Area()}");
            Console.WriteLine($"Perimeter of Square={s.Perimeter()}");

            Triangle t = new Triangle();
            t.Readdata();
            Console.WriteLine($"Area Equilateral Triangle={t.Area()}");
            Console.WriteLine($"Perimeter of Equilateral Triangle={t.Perimeter()}");
            Console.ReadLine();
        }
    }
}
