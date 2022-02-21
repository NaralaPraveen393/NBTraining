using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PraveenServices
{  //Author:Narala Praveen
    //Purpose:To create a web service
    /// <summary>
    /// Summary description for PraveenNaralaservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PraveenNaralaservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]

        public int Factorial(int n)//Factorial Method
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }

        [WebMethod]
        public int Add(int a, int b)//Addition method
        {
            return a + b;
        }
        [WebMethod]
        public int Multiplication(int a, int b)//Multiplication method
        {
            return a * b;
        }
        [WebMethod]
        public int Division(int a , int b)//Division Method
        {
            return a/b;
        }
        [WebMethod]
        public int Subtract(int a,int b)//Subtract Method
        {
            return a-b;
        }
    }
}
