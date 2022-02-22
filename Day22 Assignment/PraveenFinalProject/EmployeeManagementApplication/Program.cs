using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagementApplication
{
    public  class Program
    {  //Author:Narala Praveen
        //Purpose:Client app for Business Management
        static void Main(string[] args)
        { int p;
            string choice;
            do
            {
                Console.WriteLine("::::::::::::::::::::::::::::::::");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("::::::::::::::::::::::::::::::::");
                Console.WriteLine("1. Add Employee:");
                Console.WriteLine("2. Search Employee by ID:");
                Console.WriteLine("3. Search Employee by Name:");
                Console.WriteLine("4. Display All Employees:");
                Console.WriteLine("Enter Your Choice:");
                p =Convert.ToInt32(Console.ReadLine());

                switch(p)

                {
                    case 1:
                        AddEmployee();
                        break;


                    case 2:
                        SearchEmployee();
                        break ;

                    case 3:
                        SearchEmployeeByName();
                        break ;

                    case 4:
                        DisplayAllEmployee();
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Do you Wish to continue(y/n)");
                choice = Console.ReadLine();
            } while (choice.Equals("y"));

        }
        /// <summary>
        /// This method is for add employee data
        /// </summary>
         public static void AddEmployee()
        {
            int ID, Salary, Age;
            string Name;
            Console.WriteLine("Enter ID:");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary:");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();  

            //Call BLL method
            var result=EmployeeBLL.AddEmployee(ID,Name,Salary,Age); 

            if(result)
                Console.WriteLine("Employee Details Saved Successfully");
            else
                Console.WriteLine("Some Error Occured");

        }
        /// <summary>
        /// This method is used for Search employee data by ID
        /// </summary>
        public static void SearchEmployee()
        {
            int ID;
            Console.WriteLine("Enter ID:");
            ID=Convert.ToInt32(Console.ReadLine());
            var result = EmployeeBLL.GetEmployeeByID(ID);
            if(result.Count==0)
                Console.WriteLine("No Records Exists with these ID");
           else
            {
                result.ForEach(e => Console.WriteLine(e));  
            }
       

        }
        /// <summary>
        /// This method is used for Serach employee data by name
        /// </summary>
        public static void SearchEmployeeByName()
        {
            string Name;
            Name= Console.ReadLine();   
            Console.WriteLine("Enter Name:");
            var result = EmployeeBLL.GetEmployeeByName(Name);
            if (result.Count==0)
            {

                Console.WriteLine("No Records found on these Name");
            }
            else
            {
                result.ForEach(e => Console.WriteLine(e));
            }
        }
        /// <summary>
        /// This method is used displaying all employees data
        /// </summary>
        public static void DisplayAllEmployee()
        {
            var result = EmployeeBLL.GetAllEmployees(); 
            result.ToList().ForEach(k => Console.WriteLine(k));

        }
    }
}
