using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.domain
{
    public class Description : ISqlOperations<Description>
    {
        String  stmt;

        public int descid { get; set; }
        public String description { get; set; }
        public int topicid { get; set; }
        public Topics Topic { get; set; }

        public int Insert()
        {

            SqlHelper helper = new SqlHelper();
            return helper.DML(this);
            /*ins_stmt = "insert into Description values(";
            ins_stmt += "'" + description + "'" + ",";
            ins_stmt += "'" + Topic.topicid + "'" + ");";
            SqlHelper helper = new SqlHelper();
            return helper.DML(ins_stmt);*/
        }

        public int Update()
        {
            stmt = "Update Descriptiton SET ";
            stmt += "desc='" + description + "'" + ",";
            stmt += "tid='" + Topic.topicid + "',";
            stmt += " where did='" + descid + "'";
            SqlHelper helper = new SqlHelper();
            return helper.DML(stmt);
        }

        public int Delete()
        {
            stmt = "Update Description SET [status]=0";
            stmt += " where did='" + descid + "'";
            SqlHelper objSql = new SqlHelper();
            return objSql.DML(stmt);
        }

        public Description GetRow(string id)
        {
            stmt = "select * from Description where did='" + id + "'";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null)
                return null;
            domain.Description obj = new domain.Description();
            obj.description = dt.Rows[0]["desc"].ToString();
            String topicid = dt.Rows[0]["tid"].ToString();
            domain.Topics objDept = new domain.Topics();
            obj.Topic = objDept.GetRow(topicid);
            return obj;
        }

        public Description GetRowDescription(String _tid)
        {
            stmt = "select * from Description where tid='"+_tid+"'";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null)
                return null;
            domain.Description obj = new domain.Description();
            obj.description = dt.Rows[0]["desc"].ToString();
            String topicid = dt.Rows[0]["tid"].ToString();
            domain.Topics objDept = new domain.Topics();
            obj.Topic = objDept.GetRow(topicid);
            return obj;
        }

        public Description GetRow(string _Branchid,String _TopicId)
        {
            stmt = "select * from Description where did='" + _Branchid + "' and tid='"+ _TopicId +"'" ;
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null)
                return null;
            domain.Description obj = new domain.Description();
            obj.description = dt.Rows[0]["desc"].ToString();
            String topicid = dt.Rows[0]["tid"].ToString();
            domain.Topics objDept = new domain.Topics();
            obj.Topic = objDept.GetRow(topicid);
            return obj;
        }

        public List<Description> GetRows()
        {
            stmt = "select * from Description";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null) return null;
            List<Description> tm = new List<Description>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Description obj = new Description();
                obj.description = dt.Rows[i]["desc"].ToString();
                String topicid = dt.Rows[i]["tid"].ToString();
                domain.Topics objDept = new domain.Topics();
                obj.Topic = objDept.GetRow(topicid);
                tm.Add(obj);
            }
            return tm;
        }


    }
}
