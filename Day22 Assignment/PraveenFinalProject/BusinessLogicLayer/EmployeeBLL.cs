using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{       //Business Logic Layer
    public static class EmployeeBLL
    {
        public static bool AddEmployee(int ID,string Name,int Salary,int Age)
        {
            //to do Validations
            var result =EmployeeDAL.AddEmployee(ID, Name, Salary, Age);
            return result;  
        }
        public static List<string> GetEmployeeByID(int ID)
        {
            var result=EmployeeDAL.GetEmployeeById(ID );
            return result;
            
        }
        public static List<string> GetEmployeeByName( string Name)
        {
            var result = EmployeeDAL.GetEmployeeByName(Name);
                return result;
        }
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }
    }
}
