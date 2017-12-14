````c#
<?xml version="1.0" encoding="utf-8"?>

<!--
  如需如何設定 ASP.NET 應用程式的詳細資訊，請造訪
  http://go.microsoft.com/fwlink/?LinkId=169433
  -->

<configuration>
    
    <connectionStrings>
      <add name="im" connectionString ="Data Source=localhost;Initial Catalog=IM;Integrated Security=True"
           providerName="System.Data.SqlClient"/>
    </connectionStrings>
    <system.web>
      <compilation debug="true" targetFramework="4.5.2" />
      <httpRuntime targetFramework="4.5.2" />
    </system.web>

</configuration>
/*==========================================================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ListBox1.Items.Clear();
            string strcon = WebConfigurationManager.ConnectionStrings["im"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = strcon;
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "select userid, pass from FGO";
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            ListBox1.DataSource = sqldr;
            ListBox1.DataTextField = "userid";
            this.DataBind();
        }
    }
}
