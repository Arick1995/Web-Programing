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
        int count;
        if(ViewState["counter"] == null)
        {
            count = 1;
        }
        else
        {
            count = (int)ViewState["counter"] + 1;
        }
        ViewState["counter"] = count;
        Label1.Text = count.ToString();
    }
}
~~~~~
