````C#
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
        try
        {
            double []a = new double[10];
            double temp;
            string id;
            string s = "";
            for (int i = 1; i <= 10; i++)
            {
                TextBox b;
                id = "Textbox" + i;
                b = (TextBox)Page.FindControl(id);
                a[i - 1] = Double.Parse(b.Text);
            }
            for(int i = 0; i <= 9; i++)
            {
                for(int j = i + 1; j <= 9;j++)
                {
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    
                }
                s += a[i].ToString() + "<br>";
            }
            Label1.Text = s;
        }catch(Exception err)
        {
            Label1.Text = err.Message;
        }
        
    }
}
