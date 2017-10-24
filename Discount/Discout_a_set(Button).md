~~~~c#
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Product pr = new Product();
        double p1 = Double.Parse(TextBox1.Text);
        int n1 = Int32.Parse(TextBox2.Text);
        double d1 = Double.Parse(TextBox3.Text);
        Label1.Text = pr.Total_Price(p1, n1, d1).ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Product pr = new Product();
        double p1 = Double.Parse(TextBox1.Text);
        int n1 = Int32.Parse(TextBox2.Text);
        double d1 = Double.Parse(TextBox3.Text);
        Label1.Text = pr.Total_Price(p1, n1).ToString();
    }
}
~~~~~~~
