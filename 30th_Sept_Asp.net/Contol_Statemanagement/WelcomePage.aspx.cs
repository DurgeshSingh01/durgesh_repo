using CustomerDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace contol_statemangement
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie;
            cookie = Request.Cookies.Get("UserData");
            User usr = new User();
            usr.First_Name = cookie["FirstName"];
            usr.Last_Name = cookie["LastName"];
            usr.Date_of_Birth = Convert.ToDateTime(cookie["Dateofbirth"]);
            usr.City = cookie["City"];
            usr.State = cookie["state"];
            lblwelcome.Text = "Welcome" +" "+usr.First_Name + " " + usr.Last_Name+ ".....";
        }

        
    }
}