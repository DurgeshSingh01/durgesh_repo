using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace contol_statemangement
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            if (txtUserid.Text == "Durgesh" && Txtpassword.Text == "Durgesh@123")
            {
                
                Response.Redirect("~/WebForm2.aspx");
                
            }
            else
            {
                
                Label1.Text = "Invalid userid/password... Pls check..";

            }
        }
    }
}