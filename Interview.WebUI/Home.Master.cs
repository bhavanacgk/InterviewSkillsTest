using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class Home1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationPage.aspx");

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");

        }

        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLoginPage.aspx");

        }

       
    }
}