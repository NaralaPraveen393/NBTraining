using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project4department
{      //********************************************************************\\
       //Author:Narala Praveen
       //Purpose:To create a Department class and print id and name of department using
       //For loop
       //For each
       //Lambda Expression
       //LINQ query

    class Department
    {
        public int id;
        public string name;
        public int empcount;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Department> departments = new List<Department>
            {
                new Department() { id = 101, name="Police",empcount=25},
                new Department() { id =102, name="Excise", empcount=35},
                new Department() { id = 103, name="Incometax",empcount=45},
                new Department() { id = 104, name = "Sells",empcount =55},
                new Department() { id =105, name= "Finance", empcount =65},
            };
            //For loop
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].empcount >= 50)
                    Console.WriteLine($"id={departments[i].id},names={departments[i].name}");
            }

            //For each
            foreach (var d in departments)
            {
                if (d.empcount >= 50)
                    Console.WriteLine($"id={d.id},name={d.name}");
            }


            //Lambda Expression
            departments.ToList().Where(d => d.empcount >= 50).ToList().ForEach(d => Console.WriteLine($"id={d.id},name={d.name}"));

            //LINQ query
            var result = from d in departments
                         where d.empcount > 50
                         select d;
            result.ToList().ForEach(p => Console.WriteLine($"id={p.id},name={p.name}"));

            Console.ReadLine();
        }
    }
}
