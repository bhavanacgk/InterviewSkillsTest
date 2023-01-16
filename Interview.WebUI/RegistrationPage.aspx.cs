using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Interview.domain;
namespace Interview.WebUI
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        #region UserDefinedFunctions
        private void myClear()
        {
           // txtRegid.Text = String.Empty;
            txtName.Text = String.Empty;
            txtMail.Text = String.Empty;
            txtAdr.Text = String.Empty;
            txtMobile.Text = String.Empty;
            txtPwd.Text = String.Empty;
            txtDob.Text = String.Empty;
        }
        private void myBindRegistrations()
        {
            domain.Registration objReg = new domain.Registration();
            List<domain.Registration> Registrations = new List<domain.Registration>();
            Registrations = objReg.GetRows();
           // gvRegistration.DataSource = Registrations;
           // gvRegistration.DataBind();
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                myBindRegistrations();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Interview.domain.Registration obj = new Interview.domain.Registration();
                //obj.registrationid = int.Parse(txtRegid.Text);
                obj.name = txtName.Text;
                obj.mail = txtMail.Text;
                obj.pwd = txtPwd.Text;
                obj.ph_no = txtMobile.Text;
                String gender = null;
                if (radMale.Checked == true)
                    gender = "Male";
                else
                    gender = "Female";
                obj.gender = gender;
                obj.dob = DateTime.Parse(txtDob.Text);
                obj.address = txtAdr.Text;

                if (obj.Insert() == 1)
                {
                    lblMsg.Text = "Registered Successfully";
                    myClear();
                    myBindRegistrations();
                }
                else
                    lblMsg.Text = "Something went wrong";
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.ToString();
            }
        }

       /* protected void gvRegistration_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvRegistration.EditIndex = e.NewEditIndex;
            myBindRegistrations();
        }

        protected void gvRegistration_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String id = gvRegistration.DataKeys[e.RowIndex].Value.ToString();
            domain.Registration obj = new domain.Registration();
            obj.registrationid =int.Parse(id);
            obj.Delete();
            gvRegistration.EditIndex = -1;
            myBindRegistrations();
        }

        protected void gvRegistration_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = (GridViewRow)gvRegistration.Rows[e.RowIndex];
            String id = gvRegistration.DataKeys[e.RowIndex].Value.ToString();
            string name = ((TextBox)row.Cells[3].Controls[0]).Text;
            string mail = ((TextBox)row.Cells[4].Controls[0]).Text;
            string ph_no = ((TextBox)row.Cells[5].Controls[0]).Text;
            string address = ((TextBox)row.Cells[6].Controls[0]).Text;
            string dob = ((TextBox)row.Cells[7].Controls[0]).Text;
            domain.Registration obj = new domain.Registration();
            obj.registrationid =int.Parse(id);
            obj.name = name;
            obj.mail = mail;
            obj.ph_no = ph_no;
            obj.address = address;
            obj.dob = DateTime.Parse(dob);
            obj.Update();
            gvRegistration.EditIndex = -1;
            myBindRegistrations();
        }

        protected void gvRegistration_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvRegistration.EditIndex = -1;
            myBindRegistrations();
        }

        protected void txtRegid_TextChanged(object sender, EventArgs e)
        {

        }

        protected void gvRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      */
    }
}