using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interview.WebUI
{
    public partial class TakeTest : System.Web.UI.Page
    {

        #region Properties

        private DataTable GenerateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SNo", typeof(Int16));
            dt.Columns.Add("QNo", typeof(String));
            dt.Columns.Add("ActualAns", typeof(String));
            dt.Columns.Add("ChoosenAns", typeof(String));
            return dt;
        }

        private List<domain.TestPaper> GetQuestions()
        {
            String _topicId = Request.QueryString["tid"].ToString();
            domain.TestPaper obj = new domain.TestPaper();
            List<domain.TestPaper> questions = obj.GetRows(_topicId);
            DataTable temp = (DataTable)Session["tab"];
            int cnt = 1;
            foreach (domain.TestPaper tp in questions)
            {
                
                DataRow dr = temp.NewRow();
                dr["SNo"] = cnt;
                dr["QNo"] = tp.quesid.ToString();                
                dr["ActualAns"] = tp.ans.ToString();
                dr["ChoosenAns"] = "0";
                cnt++;
                temp.Rows.Add(dr);
            }
            return questions;
        }

        private void ClearChoices()
        {
            rbtnChoice1.Checked = false;
            rbtnChoice2.Checked = false;
            rbtnChoice3.Checked = false;
            rbtnChoice4.Checked = false;
        }

        private void BindQuestion(int QuestionNumber)
        {
            ClearChoices();

            List<domain.TestPaper> questions = GetQuestions();
            
            lblSno.Text = QuestionNumber.ToString();
            lblQuestion.Text = questions[QuestionNumber].ques.ToString();
            rbtnChoice1.Text = questions[QuestionNumber].choice1.ToString();
            rbtnChoice2.Text = questions[QuestionNumber].choice2.ToString();
            rbtnChoice3.Text = questions[QuestionNumber].choice3.ToString();
            rbtnChoice4.Text = questions[QuestionNumber].choice4.ToString();
        }

        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataTable temp = GenerateTable();
                Session["tab"] = temp;
                BindQuestion(1);
                
                //gvTest.DataSource = temp;
                //gvTest.DataBind();
            }
        }

        protected void btnSaveAndNext_Click(object sender, EventArgs e)
        {
            int qno = int.Parse(lblSno.Text);
            qno++;
            if(qno <= 10)
                BindQuestion(qno);

            DataTable temp = (DataTable)Session["tab"];
            String choosenAns = temp.Rows[qno - 1]["ChoosenAns"].ToString();
            if (temp.Rows[qno-1]["ChoosenAns"].ToString() == "A")
                rbtnChoice1.Checked = true;
            else if (temp.Rows[qno - 1]["ChoosenAns"].ToString() == "B")
                rbtnChoice2.Checked = true;
            else if (temp.Rows[qno - 1]["ChoosenAns"].ToString() == "C")
                rbtnChoice3.Checked = true;
            else if (temp.Rows[qno - 1]["ChoosenAns"].ToString() == "D")
                rbtnChoice4.Checked = true;
        }
      

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            int cnt = 0;
            DataTable temp = (DataTable)Session["tab"];
            foreach(DataRow dr in temp.Rows)
            {
                if (dr["ChoosenAns"].ToString() == dr["ActualAns"].ToString())
                    cnt++;
            }
            Session["count"] = cnt.ToString();
           Response.Redirect("ResultsPage.aspx");
        }

        protected void btnPrev_Click1(object sender, EventArgs e)
        {
            int qno = int.Parse(lblSno.Text);
            qno--;
            if (qno >= 1)
                BindQuestion(qno);

            DataTable temp = (DataTable)Session["tab"];
            String choosenAns = temp.Rows[qno - 1]["ChoosenAns"].ToString();
            if (temp.Rows[qno - 1]["ChoosenAns"].ToString() == "A")
                rbtnChoice1.Checked = true;
            else if (temp.Rows[qno - 1]["ChoosenAns"].ToString() == "B")
                rbtnChoice2.Checked = true;
            else if (temp.Rows[qno - 1]["ChoosenAns"].ToString() == "C")
                rbtnChoice3.Checked = true;
            else if (temp.Rows[qno - 1]["ChoosenAns"].ToString() == "D")
                rbtnChoice4.Checked = true;
        }

        protected void btnQues1_Click(object sender, EventArgs e)
        {
            BindQuestion(1);
        }

        protected void btnQues2_Click(object sender, EventArgs e)
        {
            BindQuestion(2);
        }

        protected void btnQues3_Click(object sender, EventArgs e)
        {
            BindQuestion(3);
        }

        protected void btnQues4_Click(object sender, EventArgs e)
        {
            BindQuestion(4);
        }

        protected void btnQues5_Click1(object sender, EventArgs e)
        {
            BindQuestion(5);
        }

        protected void btnQues6_Click(object sender, EventArgs e)
        {
            BindQuestion(6);
        }

        protected void btnQues7_Click(object sender, EventArgs e)
        {
            BindQuestion(7);
        }

        protected void btnQues8_Click(object sender, EventArgs e)
        {
            BindQuestion(8);
        }

        protected void btnQues9_Click(object sender, EventArgs e)
        {
            BindQuestion(9);
        }

        protected void btnQues10_Click(object sender, EventArgs e)
        {
            BindQuestion(10);
        }

        protected void rbtnChoice1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable temp = (DataTable)Session["tab"];
            int qno = int.Parse(lblSno.Text);
            temp.Rows[qno-1]["ChoosenAns"] = "A";
            Session["tab"] = temp;
            //gvTest.DataSource = temp;
            //gvTest.DataBind();
            //DataRow dr = temp.Rows[qno];
            //dr["ChoosenAns"] = "A";

        }

        protected void rbtnChoice2_CheckedChanged(object sender, EventArgs e)
        {
            DataTable temp = (DataTable)Session["tab"];
            int qno = int.Parse(lblSno.Text);
            temp.Rows[qno - 1]["ChoosenAns"] = "B";
            Session["tab"] = temp;
            //gvTest.DataSource = temp;
            //gvTest.DataBind();
        }

        protected void rbtnChoice3_CheckedChanged(object sender, EventArgs e)
        {
            DataTable temp = (DataTable)Session["tab"];
            int qno = int.Parse(lblSno.Text);
            temp.Rows[qno - 1]["ChoosenAns"] = "C";
            Session["tab"] = temp;
            //gvTest.DataSource = temp;
            //gvTest.DataBind();
        }

        protected void rbtnChoice4_CheckedChanged(object sender, EventArgs e)
        {
            DataTable temp = (DataTable)Session["tab"];
            int qno = int.Parse(lblSno.Text);
            temp.Rows[qno - 1]["ChoosenAns"] = "D";
            Session["tab"] = temp;
            //gvTest.DataSource = temp;
            //gvTest.DataBind();
        }
        static int mm, ss;

        static double TimeAllSecondes = 600; //360 is no. of seconds(from 5 min TO 0)
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (TimeAllSecondes > 0)
            {
                TimeAllSecondes = TimeAllSecondes - 1;
            }
            else
            {
                int cnt = 0;
                DataTable temp = (DataTable)Session["tab"];
                foreach (DataRow dr in temp.Rows)
                {
                    if (dr["ChoosenAns"].ToString() == dr["ActualAns"].ToString())
                        cnt++;
                }
                Session["count"] = cnt.ToString();
                Response.Redirect("ResultsPage.aspx");
            }

            TimeSpan time_Span = TimeSpan.FromSeconds(TimeAllSecondes);

            mm = time_Span.Minutes;
            ss = time_Span.Seconds;

            Label2.Text = "  " + mm + " Min " + ss + " Sec ";
        }

       
    }
}