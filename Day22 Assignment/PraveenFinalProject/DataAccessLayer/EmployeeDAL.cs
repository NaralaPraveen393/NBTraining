using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{   //Data Access Layer for data storing
    public class EmployeeDAL
    {
        public static string filepath = "C:\\NBHtraining\\Day22 Assignment\\Employee.txt";
        public static bool AddEmployee(int Id, string Name, int Salary, int Age)
        {
            try
            {
                string textcontent = string.Concat(Id, ",", Name, ",", Salary, ",", Age);
                File.AppendAllText(filepath, textcontent + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static List<string> GetEmployeeById(int ID)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;

            List<string> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == ID)
                {
                    isFound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }
        public static List<string> GetEmployeeByName(string Name)
        {
            var allEmployees = File.ReadAllLines(filepath);
            

            List<string> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(Name))
                {

                    employeeFound.Add(employee);



                }
            }
            return employeeFound;
            
        }
        public static string[] GetAllEmployees()
        {
            var allEmployees=File.ReadAllLines(filepath);
            return allEmployees;
        }
    }
}
