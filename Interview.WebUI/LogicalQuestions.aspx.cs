using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class LogicalQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTakeTest_Click(object sender, EventArgs e)
        {
            if (Session["name"] != null)

            Response.Redirect("TakeTest.aspx?bid=6&tid=21");
            else
                Response.Redirect("ErrorPage.aspx");

        }

        
    }
}