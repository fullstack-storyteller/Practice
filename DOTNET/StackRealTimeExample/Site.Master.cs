using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackRealTimeExample
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session["BackButtonClicked"] = "Yes";
            if (Session["URL_STACK"] != null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URL_STACK"];
                if (urlStack.Count > 0)
                {
                    string url = ((Stack<string>)Session["URL_STACK"]).Pop();
                    Response.Redirect(url);
                }
                else
                    lblMessage.Text = "There are no pages in the history";
            }
        }
    }
}