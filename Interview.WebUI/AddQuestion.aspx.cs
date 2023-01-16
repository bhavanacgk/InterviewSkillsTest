using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class AddQuestion : System.Web.UI.Page
    {

        #region UserDefinedFunctions
        private void usrClear()
        {
            // txtRegid.Text = String.Empty;
            txtQues.Text = String.Empty;
            txtChoice1.Text = String.Empty;
            txtChoice2.Text = String.Empty;
            txtChoice3.Text = String.Empty;
            txtChoice4.Text = String.Empty;
            txtAnswer.Text = String.Empty;
            txtTseries.Text = String.Empty;
            txtHint.Text = String.Empty;
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
        private void usrBindQuestion()
        {
            domain.TestPaper obj = new domain.TestPaper();
            List<domain.TestPaper> _ques = new List<domain.TestPaper>();
            _ques = obj.GetRows();

        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usrBindTopic();
                usrBindQuestion();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Interview.domain.TestPaper obj = new Interview.domain.TestPaper();
                obj.ques = txtQues.Text;
                obj.choice1 = txtChoice1.Text;
                obj.choice2 = txtChoice2.Text;
                obj.choice3 = txtChoice3.Text;
                obj.choice4 = txtChoice4.Text;
                obj.ans = txtAnswer.Text;
                obj.tseries = txtTseries.Text;
                obj.hint = txtHint.Text;

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