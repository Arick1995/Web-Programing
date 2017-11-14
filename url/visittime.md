````c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int c;
        Application.Lock();
        if (Application["count"] != null)
        {
            c = (int)Application["count"];
            c++;
        }else
        {
            c = 1;
        }
        Application["count"] = c;
        Label1.Text = c.ToString();
        Application.UnLock();
    }
}
