using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //tempuri.org.WebServiceMathsSoap myClient = new tempuri.org.WebServiceMathsSoap();
        //lblResult = myClient.Add(txtNum1.Text, txtNum2.Text);

        WebServiceMaths ws = new WebServiceMaths();
        lblResult.Text = ws.Add(txtNum1.Text, txtNum2.Text);
    }

    protected void btnSubtract_Click(object sender, EventArgs e)
    {
        WebServiceMaths ws = new WebServiceMaths();
        lblResult.Text = ws.Subtract(txtNum1.Text, txtNum2.Text);
    }

    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        WebServiceMaths ws = new WebServiceMaths();
        lblResult.Text = ws.Multiply(txtNum1.Text, txtNum2.Text);
    }

    protected void btnDivide_Click(object sender, EventArgs e)
    {
        WebServiceMaths ws = new WebServiceMaths();
        lblResult.Text = ws.Divide(txtNum1.Text, txtNum2.Text);
    }
}