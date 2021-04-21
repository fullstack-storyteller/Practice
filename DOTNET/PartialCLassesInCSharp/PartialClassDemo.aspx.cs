using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialCLassesInCSharp
{
    public partial class PartialClassDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer fullCustomer = new Customer();
            fullCustomer.LastName = "Kumar";
            fullCustomer.FirstName = "Manish";

            Response.Write( "Full Name: "+fullCustomer.GetFullName() + "<br/>");
            //this way we just wrote our name in the webform using a complete class
            //lets try to do the same using the partial class
            Response.Write("<br/>");

            PartialCustomer partialCustomer = new PartialCustomer();
            partialCustomer.LastName = "Kumar Partial";
            partialCustomer.FirstName = "Manish Partial";
            
            Response.Write("Full Name from partial: " + partialCustomer.GetFullName() + "<br/>");
            Response.Write("<br/>");
            Response.Write("Working with a Partial Method: WorkingWithPartialMethods(string fname) <br/>");
            Response.Write(partialCustomer.WorkingWithPartialMethods(partialCustomer.FirstName));
            Response.Write("<br/>");

            Response.Write("1. A partial Class or struct can contains a partial method<br/>");
            Response.Write("2. A partial method is create using a partial method <br/>");
            Response.Write("3. A partial  method declaration consists of two parts: (i) The definition - Only the method signature (ii) The implementation<br/>");
            Response.Write("    These may be separate parts of the partial class or the same Part<br/>");
            Response.Write("4. The implementation of the partial method is optional.<br/>");
            Response.Write("5. [Most Important] Partial methods are private by default, and we are not allowed to explicitly use even the 'private keyword'<br/>");
            Response.Write("6. It is a compile time error to use the declaration and implementation at the same time for a partial method.<br/>");
            Response.Write("7. [Most Important] A partial method's return type must be 'void'<br/>");
            Response.Write("8. Signature of a partial class declaration must match with the signature of that partial class implementation<br/>");
            Response.Write("9. A partial method must be declared within a partial struct or a partial class. <br/>A non-partial class con't have a partial method<br/>");
            Response.Write("10. A partial method can be implemeted only once.<br/>");
        } 
    }
}