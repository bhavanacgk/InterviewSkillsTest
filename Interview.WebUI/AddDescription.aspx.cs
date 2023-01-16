using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class AddDescription : System.Web.UI.Page
    {

        #region UserDefinedFunctions
        private void usrClear()
        {
            txtDesc.Text = String.Empty;
            ddlTopic.SelectedIndex = 0;
        }

        private void usrBindTopic()
        {
            Interview.domain.Topics obj = new domain.Topics();
            List<domain.Topics> topic = new List<domain.Topics>();
            topic = obj.GetRows();
            ddlTopic.DataSource = topic;
            ddlTopic.DataTextField = "name";
            ddlTopic.DataValueField = "topicid";
            ddlTopic.DataBind();
            ListItem li = new ListItem() { Text = "Select", Value = "Select" };
            ddlTopic.Items.Insert(0, li);
        }

        private void usrBindDescription()
        {
            domain.Description obj = new domain.Description();
            List<domain.Description> _desc = new List<domain.Description>();
            _desc = obj.GetRows();
            
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usrBindTopic();
                usrBindDescription();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Interview.domain.Description obj = new Interview.domain.Description();
                obj.description = txtDesc.Text;
                domain.Topics objtopic = new domain.Topics();
                objtopic.topicid = int.Parse(ddlTopic.SelectedItem.Value);
                obj.Topic = objtopic;
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
    }
}