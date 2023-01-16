using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class AdminLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            domain.Admin obj = new domain.Admin();
            obj.name = txtUname.Text;
            obj.pwd = txtPwd.Text;
            if (obj.GetRecordCount() == 1)
            {
                Session["name"] = txtUname.Text;
                Response.Redirect("HomeAdmin.aspx");
                //here you need specify required path            
            }
            else
                lblMsg.Text = "Invalid User"; 
        }
    }
}