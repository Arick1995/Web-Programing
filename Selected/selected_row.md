````c#
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
    
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
    
    }
    
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {        
        int index = Convert.ToInt32(e.CommandArgument);        
        if(e.CommandName == "aaa")        
    {            
        Label1.Text = "Class";            
        Label2.Text = GridView1.Rows[index].Cells[1].Text;        
    }else        
    {            
        Label1.Text = "Rare";
        Label2.Text = GridView1.Rows[index].Cells[2].Text;
    } 
    }
    }
