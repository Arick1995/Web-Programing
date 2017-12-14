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
        try
        {
            string strcon = "Data Source=localhost;Initial Catalog=IM;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(strcon);
            sqlcon.ConnectionString = strcon;
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "select usedid, pass from FGO where useid=@v";
            sqlcmd.Parameters.AddWithValue("@v", TextBox1.Text);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                sqldr.Read();
                if (sqldr.GetString(1).Equals(TextBox2.Text))
                {
                    Label1.Text = "Succes";
                }
                else
                {
                    Label1.Text = "Password wrong !!!";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                }
            }
            else
            {
                Label1.Text = "Failed";
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            sqlcon.Close();
        }
        catch (SqlException err)
        {
            Label1.Text = err.Message;
        }
    }
}
