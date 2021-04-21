using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NamedServiceContractClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloService.NamedServiceContractsClient client = new
                HelloService.NamedServiceContractsClient("BasicHttpBinding_INamedServiceContracts");
            Label1.Text= client.SayHello(TextBox1.Text);
        }
    }
}