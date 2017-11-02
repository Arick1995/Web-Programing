````C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) //Also can be "if(!IsPostBack)"
        {
            ListItem a = new ListItem("Just Monika.", "0");
            ListItem b = new ListItem("Just Mon-ika.", "1");
            DropDownList1.Items.Add(a);
            DropDownList1.Items.Add(b);
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = DropDownList1.SelectedItem.Text;
    }
}
````
