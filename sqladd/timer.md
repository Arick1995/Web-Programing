````c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     Label1.Text = DateTime.Now.ToString();
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
     Label1.Text = DateTime.Now.ToString();
    }
}
