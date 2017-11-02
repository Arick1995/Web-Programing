````C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ViewState["content"] = TextBox1.Text;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = ViewState["content"].ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Text = TextBox1.Text;
    }
}
`````
