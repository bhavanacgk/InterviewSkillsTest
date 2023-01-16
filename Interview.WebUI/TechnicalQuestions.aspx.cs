using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class TechnicalQuestions : System.Web.UI.Page
    {
        #region UserDefinedFunctions
        private void usrClear()
        {
            ddlBranch.SelectedIndex = 0;

        }
        private void usrBindBranch()
        {
            Interview.domain.Branch obj = new domain.Branch();
            List<domain.Branch> branch = new List<domain.Branch>();
            branch = obj.GetRows();
            ddlBranch.DataSource = branch;
            ddlBranch.DataTextField = "name";
            ddlBranch.DataValueField = "branchid";
            ddlBranch.DataBind();
            ListItem li = new ListItem() { Text = "Select", Value = "Select" };
            ddlBranch.Items.Insert(0, li);
        }
        private void usrBindTopic()
        {
            domain.Topics objTopic = new domain.Topics();
            List<domain.Topics> Topic = new List<domain.Topics>();
            Topic = objTopic.GetRows(ddlBranch.SelectedItem.Value);
            ddlTopic.DataSource = Topic;
            ddlTopic.DataTextField = "name";
            ddlTopic.DataValueField = "topicid";
            ddlTopic.DataBind();
            ListItem li = new ListItem() { Text = "Select", Value = "Select" };
            ddlTopic.Items.Insert(0, li);
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usrBindBranch();
            }
        }

        protected void ddBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlTopic.Items.Clear();
            ListItem li = new ListItem() { Text = "Select", Value = "Select" };
            ddlTopic.Items.Insert(0, li);

            if(ddlBranch.SelectedItem.Value != "Select")
                usrBindTopic();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Interview.domain.Description obj = new domain.Description();
            domain.Description temp = obj.GetRowDescription(ddlTopic.SelectedItem.Value);
           
            lblDesc.Text = temp.description;

                    
        }

        protected void btnTakeTest_Click(object sender, EventArgs e)
        {
            if (Session["name"] != null)
                Response.Redirect("TakeTest.aspx?bid=" + ddlTopic.SelectedItem.Value + "&tid=" + ddlTopic.SelectedItem.Value);
            else
                Response.Redirect("ErrorPage.aspx");
        }

        protected void ddlTopic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}