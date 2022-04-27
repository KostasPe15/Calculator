using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    com.dneonline.www.Calculator myWS = new com.dneonline.www.Calculator();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int a, b, apot;
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        apot = myWS.Add(a,b);

        Label1.Text = Convert.ToString(apot);
    }

    protected void btnSubtract_Click(object sender, EventArgs e)
    {
        int a, b, apot;
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        apot = myWS.Subtract(a, b);

        Label1.Text = Convert.ToString(apot);
    }

    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        int a, b, apot;
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        apot = myWS.Multiply(a, b);

        Label1.Text = Convert.ToString(apot);
    }

    protected void btnDivide_Click(object sender, EventArgs e)
    {

        int a, b, apot;
        a = Convert.ToInt32(TextBox1.Text);
        b = Convert.ToInt32(TextBox2.Text);

        if (b != 0)
        {
            apot = myWS.Divide(a, b);
            Label1.Text = Convert.ToString(apot);
        }
        else Label1.Text = "Δεν ορίζεται!";
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        Label1.Text = "";
    }
}