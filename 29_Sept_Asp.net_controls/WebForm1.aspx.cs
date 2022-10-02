using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationIntro
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Response.Write("coming to the page for the first time");
            }
            else
            {
                Response.Write("Thank you for arriving again on this page");
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox3.Text = dobcalender.SelectedDate.ToLongDateString();
        }
    }
}