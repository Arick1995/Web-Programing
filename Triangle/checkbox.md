`````c#
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
        string r = "";
        if (CheckBox1.Checked == true)
            r += CheckBox1.Text + "<br>";
        if (CheckBox2.Checked == true)
            r += CheckBox2.Text + "<br>";
        if (CheckBox3.Checked == true)
            r += CheckBox3.Text + "<br>";
        Label1.Text = r;
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        string s = "";
        if (RadioButton1.Checked == true)
            s += RadioButton1.Text + "<br>";
        if (RadioButton2.Checked == true)
            s += RadioButton2.Text + "<br>";
        Label2.Text = s;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string t = "";
        foreach(ListItem i in CheckBoxList1.Items)
        {
            if (i.Selected)
            {
                t += i.Text + "<br>";
            }
        }
        Label3.Text = t;
    }
}
``````
