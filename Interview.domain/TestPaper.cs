using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.domain
{
    public class TestPaper:ISqlOperations<TestPaper>
    {
        String ins_stmt,stmt;
        public int quesid { get; set; }
        public String ques { get; set; }
        public String choice1 { get; set; }
        public String choice2 { get; set; }
        public String choice3 { get; set; }
        public String choice4 { get; set; }
        public String ans { get; set; }
        public String tseries { get; set; }
        public String hint { get;set; }
        public int topicid { get; set; }
        public Topics Topic { get; set; }



        public int Insert()
        {
            ins_stmt = "insert into TestPaper(ques,choice1,choice2,choice3,choice4,ans,tseries,hint,tid) values(";
            //ins_stmt += "'" + quesid + "'" + ",";
            ins_stmt += "'" + ques + "'" + ",";
            ins_stmt += "'" + choice1 + "'" + ",";
            ins_stmt += "'" + choice2 + "'" + ",";
            ins_stmt += "'" + choice3 + "'" + ",";
            ins_stmt += "'" + choice4 + "'" + ",";
            ins_stmt += "'" + ans + "'" + ",";
            ins_stmt += "'" + tseries + "'" + ",";
            ins_stmt += "'" + hint + "'" + ",";
            ins_stmt += "'" + Topic.topicid + "'" + ");";
            SqlHelper helper = new SqlHelper();
            return helper.DML(ins_stmt);
        }

        public int Update()
        {
            stmt = "Update TestPaper SET ";
            stmt += "ques='" + ques + "'" + ",";
            stmt += "choice1='" + choice1 + "'" + ",";
            stmt += "choice2='" + choice2 + "'" + ",";
            stmt += "choice3='" + choice3 + "'" + ",";
            stmt += "choice4='" + choice4 + "'" + ",";
            stmt += "tid='" + Topic.topicid + "',";
            stmt += " where qid='" + quesid + "'";
            SqlHelper helper = new SqlHelper();
            return helper.DML(stmt);
        }

        public int Delete()
        {
            stmt = "Update TestPaper SET [status]=0";
            stmt += " where qid='" + quesid + "'";
            SqlHelper objSql = new SqlHelper();
            return objSql.DML(stmt);
        }

        public TestPaper GetRow(string id)
        {
            stmt = "select * from TestPaper where qid='" + id + "'";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null)
                return null;
            domain.TestPaper obj = new domain.TestPaper();
            obj.quesid = int.Parse(dt.Rows[0]["qid"].ToString());
            obj.ques = dt.Rows[0]["ques"].ToString();
            obj.choice1 = dt.Rows[0]["choice1"].ToString();
            obj.choice2 = dt.Rows[0]["choice2"].ToString();
            obj.choice3 = dt.Rows[0]["choice3"].ToString();
            obj.choice4 = dt.Rows[0]["choice4"].ToString();
            obj.ans = dt.Rows[0]["ans"].ToString();
            obj.tseries = dt.Rows[0]["tseries"].ToString();
            obj.hint = dt.Rows[0]["hint"].ToString();
            String topicid = dt.Rows[0]["tid"].ToString();
            domain.Topics objDept = new domain.Topics();
            obj.Topic = objDept.GetRow(topicid);
            return obj;
        }

        public List<TestPaper> GetRows()
        {
            stmt = "select * from TestPaper";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null) return null;
            List<TestPaper> tm = new List<TestPaper>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TestPaper obj = new TestPaper();
                obj.quesid = int.Parse(dt.Rows[i]["qid"].ToString());
                obj.ques = dt.Rows[i]["ques"].ToString();
                obj.choice1 = dt.Rows[i]["choice1"].ToString();
                obj.choice2 = dt.Rows[i]["choice2"].ToString();
                obj.choice3 = dt.Rows[i]["choice3"].ToString();
                obj.choice4 = dt.Rows[i]["choice4"].ToString();
                obj.ans = dt.Rows[i]["ans"].ToString();
                obj.tseries = dt.Rows[i]["tseries"].ToString();
                obj.hint = dt.Rows[i]["hint"].ToString();
                String topicid = dt.Rows[i]["tid"].ToString();
                domain.Topics objDept = new domain.Topics();
                obj.Topic = objDept.GetRow(topicid);
                tm.Add(obj);
            }
            return tm;
        }
        public List<TestPaper> GetRows(String _TestPaperId)
        {
            stmt = "select * from TestPaper where tid='" + _TestPaperId + "'";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null) return null;
            List<TestPaper> TestPapersMembers = new List<TestPaper>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TestPaper obj = new TestPaper();
                obj.quesid = int.Parse(dt.Rows[i]["qid"].ToString());
                obj.ques = dt.Rows[i]["ques"].ToString();
                obj.choice1 = dt.Rows[i]["choice1"].ToString();
                obj.choice2 = dt.Rows[i]["choice2"].ToString();
                obj.choice3 = dt.Rows[i]["choice3"].ToString();
                obj.choice4 = dt.Rows[i]["choice4"].ToString();
                obj.ans = dt.Rows[i]["ans"].ToString();
                obj.tseries = dt.Rows[i]["tseries"].ToString();
                obj.hint = dt.Rows[i]["hint"].ToString();
                String topicid = dt.Rows[0]["tid"].ToString();
                domain.Topics objDept = new domain.Topics();
                obj.Topic = objDept.GetRow(topicid);
                TestPapersMembers.Add(obj);
            }
            return TestPapersMembers;
        }
    }
}
