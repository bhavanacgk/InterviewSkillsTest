using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class ResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnConfirmSubmit_Click(object sender, EventArgs e)
        {
            if (Session["count"] != null)
            {
                lblResult.Text = "Your result for the test is " + Session["count"].ToString();
                Label1.Visible = true;
                hlHome.Visible = true;
            }
        }

        

    }
}