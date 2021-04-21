using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            TestService.CalculatorServiceSoapClient client = new TestService.CalculatorServiceSoapClient();
            lblResult.Text = client.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text)).ToString();

        }

        protected void btnAdd3Number_Click(object sender, EventArgs e)
        {
            TestService.CalculatorServiceSoapClient client = new TestService.CalculatorServiceSoapClient();
            Label1.Text = client.Add1(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text)).ToString();
        }
    }
}