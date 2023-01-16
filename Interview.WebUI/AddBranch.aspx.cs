using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class AddBranch : System.Web.UI.Page
    {

        #region UserDefinedFunctions
        private void myClear()
        {
            // txtRegid.Text = String.Empty;
            txtBname.Text = String.Empty;
           
        }
        private void myBindBranchs()
        {
            domain.Branch objBr = new domain.Branch();
            List<domain.Branch> branch = new List<domain.Branch>();
            branch = objBr.GetRows();
            gvBranch.DataSource = branch;
            gvBranch.DataBind();
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                myBindBranchs();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try{
            Interview.domain.Branch obj = new Interview.domain.Branch();
            obj.name = txtBname.Text;
             if (obj.Insert() == 1)
                {
                    lblMsg.Text = "Inserted Successfully";
                    myClear();
                    myBindBranchs();
                }
                else
                    lblMsg.Text = "Something went wrong";
            }
            catch(Exception ex)
            {
                lblMsg.Text = ex.ToString();
            }
        }

        protected void gvBranch_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvBranch.EditIndex = e.NewEditIndex;
            myBindBranchs();

        }

        protected void gvBranch_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String id = gvBranch.DataKeys[e.RowIndex].Value.ToString();
            domain.Branch obj = new domain.Branch();
            obj.branchid = int.Parse(id);
            obj.Delete();
            gvBranch.EditIndex = -1;
            myBindBranchs();
        }

        protected void gvBranch_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)gvBranch.Rows[e.RowIndex];
            String id = gvBranch.DataKeys[e.RowIndex].Value.ToString();
            string name = ((TextBox)row.Cells[4].Controls[0]).Text;
            domain.Branch obj = new domain.Branch();
            obj.branchid = int.Parse(id);
            obj.name = name;
            obj.Update();
            gvBranch.EditIndex = -1;
            myBindBranchs();
        }

        protected void gvBranch_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvBranch.EditIndex = -1;
            myBindBranchs();
        }
    }
}