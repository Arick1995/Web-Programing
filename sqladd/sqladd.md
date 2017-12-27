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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      try{
          string constr = WebConfigurationManager.ConnectionStrings["IMConnectionString"].ConnectionString;
          SqlConnection sqlcon = new SqlConnection(constr);
          sqlcon.Open();
          SqlCommand sqlcmd = new SqlCommand();
          sqlcmd.Connection = sqlcon;
          sqlcmd.CommandText = "delete from UserAccount where Account=@a";
          sqlcmd.Parameters.AddWithValue("@a",Textbox1.Text);
          sqlcmd.ExcuteNonQuery();
          sqlcon.Close();
        }catch(SqlException err)
    {
        
    }
}
