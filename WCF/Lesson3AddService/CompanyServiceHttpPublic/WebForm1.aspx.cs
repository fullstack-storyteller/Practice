using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyServiceHttpPublic
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyPublicServiceClient publicCLient
                = new CompanyService.CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");

            Label1.Text= publicCLient.PublicInformation();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyPrivateServiceClient privateCLient
                = new CompanyService.CompanyPrivateServiceClient("NetTcpBinding_ICompanyPrivateService");

            Label2.Text = privateCLient.PrivateInformation();
        }
    }
}