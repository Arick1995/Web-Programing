````c#
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

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int sum = 0;
        ListItem i = new ListItem();
        i.Text = GridView1.SelectedRow.Cells[1].Text;
        i.Value = GridView1.SelectedRow.Cells[0].Text;
        ListBox1.Items.Add(i);
        foreach(ListItem q in ListBox1.Items)
        {
            sum += Int32.Parse(q.Value);
        }
        Label1.Text = sum.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int sum = 0;
        ListBox1.Items.Remove(ListBox1.SelectedItem);
        foreach (ListItem q in ListBox1.Items)
        {
            sum += Int32.Parse(q.Value);
        }
        Label1.Text = sum.ToString();
    }
}
