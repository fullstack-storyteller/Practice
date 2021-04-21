using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDemo
{
    /// <summary>
    /// Summary description for CalculatorService
    /// </summary>
    [WebService(Namespace = "http://aig.com/webservices/", Description = "This is webservice which will add number")]
    
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //We need to use the wsiprofile as None when we have the overloaded, like below.
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorService : System.Web.Services.WebService
    {
        [WebMethod(Description = "This web method will add two number.", MessageName = "Add2Number", CacheDuration = 30)]
        public int Add(int firstNumber, int secondNumber)
        {
            //return "Hello World";
            return firstNumber + secondNumber;
        }

        [WebMethod(Description = "This web method will add three number.", MessageName = "Add3Number", CacheDuration = 30)]
        public int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            //return "Hello World";
            return firstNumber + secondNumber + thirdNumber;

        }
    }
}
