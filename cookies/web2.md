using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page{    
  protected void Page_Load(object sender, EventArgs e){        
    HttpCookie ccc = Request.Cookies["Hello"];        
    if (ccc != null) {           
      Label1.Text = ccc["name"];        
      }else
      {            
        Label1.Text = "Opps...404 No Found";        
        }    
       }
      }
