using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class AddTopic : System.Web.UI.Page
    {

        #region UserDefinedFunctions
        private void usrClear()
        {
            // txtRegid.Text = String.Empty;
            txtTname.Text = String.Empty;
            ddBranch.SelectedIndex = 0;

        }
        private void usrBindBranch()
        {
            Interview.domain.Branch obj = new domain.Branch();
            List<domain.Branch> branch = new List<domain.Branch>();
            branch = obj.GetRows();
            ddBranch.DataSource = branch;
            ddBranch.DataTextField = "name";
            ddBranch.DataValueField = "branchid";
            ddBranch.DataBind();
            ListItem li = new ListItem() { Text = "Select", Value = "Select" };
            ddBranch.Items.Insert(0, li);
        }
        private void usrBindTopic() 
        { 
            domain.Topics objTopic = new domain.Topics(); 
            List<domain.Topics> Topic = new List<domain.Topics>();
            Topic = objTopic.GetRows(); 
            gvTopic.DataSource = Topic;
            gvTopic.DataBind();
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usrBindBranch();
                usrBindTopic();
            }
        }

        protected void txtTname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Interview.domain.Topics obj = new Interview.domain.Topics();
                obj.name = txtTname.Text;
                domain.Branch objDept = new domain.Branch();
                objDept.branchid = int.Parse(ddBranch.SelectedItem.Value);
                obj.Branch = objDept;
                if (obj.Insert() == 1)
                {
                    lblMsg.Text = "Inserted Successfully";
                    usrClear();
                    usrBindTopic();
                }
                else
                    lblMsg.Text = "Something went wrong";
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.ToString();
            }
        }

        protected void gvTopic_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String id = gvTopic.DataKeys[e.RowIndex].Value.ToString();
            domain.Topics obj = new domain.Topics();
            obj.topicid = int.Parse(id);
            obj.Delete();
            gvTopic.EditIndex = -1;
            usrBindTopic();
        }

        protected void gvTopic_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvTopic.EditIndex = -1;
            usrBindTopic();
        }

        protected void gvTopic_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)gvTopic.Rows[e.RowIndex];
            String id = gvTopic.DataKeys[e.RowIndex].Value.ToString();
            String name = ((TextBox)row.FindControl("txtBname")).Text;
            domain.Topics obj = new domain.Topics();
            obj.topicid = int.Parse(id);
            obj.name = name;
            obj.Update();
            gvTopic.EditIndex = -1;
            usrBindTopic();
        }

        protected void gvTopic_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvTopic.EditIndex = e.NewEditIndex;
            usrBindTopic();
        }

        protected void ddBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvTopic_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && gvTopic.EditIndex == e.Row.RowIndex)
            {
                Interview.domain.Branch obj = new domain.Branch();
                List<domain.Branch> departments = new List<domain.Branch>();
                departments = obj.GetRows();
                DropDownList ddl1 = (DropDownList)e.Row.FindControl("ddBname");
                ddl1.DataSource = departments;
                ddl1.DataTextField = "name";
                ddl1.DataValueField = "branchid";
                ddl1.DataBind();
                String bid = DataBinder.Eval(e.Row.DataItem, "Branch.branchid").ToString();
                ddl1.Items.FindByValue(bid).Selected = true;
            }
        }
    }
}