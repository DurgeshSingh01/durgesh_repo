using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerDetails;
namespace contol_statemangement
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            User usr = new User();
            usr.First_Name= txtfirst.Text;
            usr.Last_Name= txtlast.Text;
            usr.Date_of_Birth =Convert.ToDateTime(txtdob.Text);
            usr.City = txtcity.Text;
            usr.State= txtstate.Text;

            HttpCookie cookie = new HttpCookie("UserData");
            cookie.Expires = DateTime.Now.AddMinutes(10);

            cookie.Values.Add("FirstName", usr.First_Name);
            cookie.Values.Add("LastName", usr.Last_Name);
            cookie.Values.Add("DateofBirth", usr.Date_of_Birth.ToString());
            cookie.Values.Add("City", usr.City);
            cookie.Values.Add("State", usr.State);
            Response.Redirect("~/WelcomePage.aspx");

        }
    }
}