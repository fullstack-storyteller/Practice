using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackRealTimeExample
{
    public class BasePage :System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);
            if (Session["URL_STACK"] == null)
            {
                Stack<string> urlStack = new Stack<string>();
                Session["URL_STACK"] = urlStack;
            }

            if(Request.UrlReferrer !=null && !this.Page.IsPostBack && Session["BackButtonClicked" ] == null)
            {
                Stack<string> urlStack = (Stack<string>)Session["URL_STACK"];
                urlStack.Push(Request.UrlReferrer.AbsoluteUri);
                Session["URL_STACK"] = urlStack;
            }

            if(Session["BackButtonClicked"] != null)
            {
                Session["BackButtonClicked"] = null;
            }

        }
    }
}