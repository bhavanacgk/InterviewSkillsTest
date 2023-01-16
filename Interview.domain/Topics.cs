using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.domain
{
    public class Topics:ISqlOperations<Topics>
    {
        String ins_stmt,stmt;

        public int topicid { get; set; }
        public String name { get; set; }
        public int branchid { get; set; }
        public Branch Branch { get; set; }

        public int Insert()
        {
            ins_stmt = "insert into Topic values(";
            //ins_stmt += "'" + topicid + "'" + ",";
            ins_stmt += "'" + name + "'" + ",";
            ins_stmt += "'" + Branch.branchid + "'" + ");";
            SqlHelper helper = new SqlHelper();
            return helper.DML(ins_stmt);
        }

        public int Update()
        {
            stmt = "Update Topics SET ";
            stmt += "name='" + name + "'" + ",";
            stmt += "branchid='" + Branch.branchid + "',";
            stmt += " where tid='" + topicid + "'";
            SqlHelper helper = new SqlHelper();
            return helper.DML(stmt);
        }

        public int Delete()
        {
            stmt = "Update Topic SET [status]=0"; 
            stmt += " where tid='" + topicid + "'"; 
            SqlHelper objSql = new SqlHelper();
            return objSql.DML(stmt);
        }

        public Topics GetRow(string id)
        {
            stmt = "select * from Topic where tid='" + id + "'"; 
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt); 
            if (dt == null) 
                return null;
            Topics obj = new Topics(); 
            obj.name = dt.Rows[0]["name"].ToString(); 
            String topicid = dt.Rows[0]["bid"].ToString(); 
            domain.Branch objDept = new domain.Branch(); 
            obj.Branch = objDept.GetRow(topicid);
            return obj;
        }
        
        public List<Topics> GetRows()
        {
            stmt = "select * from Topic";
            SqlHelper objSql = new SqlHelper(); 
            System.Data.DataTable dt = objSql.GetData(stmt); 
            if (dt == null) return null;
            List<Topics> TopicsMembers = new List<Topics>(); 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Topics obj = new Topics(); 
                obj.topicid = int.Parse(dt.Rows[i]["tid"].ToString()); 
                obj.name = dt.Rows[i]["name"].ToString(); 
                String bid = dt.Rows[i]["bid"].ToString(); 
                domain.Branch objDept = new domain.Branch(); 
                obj.Branch = objDept.GetRow(bid);
                TopicsMembers.Add(obj);
            }
            return TopicsMembers;
        }
        public List<Topics> GetRows(String _BranchId)
        {
            stmt = "select * from Topic where bid='"+_BranchId+"'";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null) return null;
            List<Topics> TopicsMembers = new List<Topics>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Topics obj = new Topics();
                obj.topicid = int.Parse(dt.Rows[i]["tid"].ToString());
                obj.name = dt.Rows[i]["name"].ToString();
                String bid = dt.Rows[i]["bid"].ToString();
                domain.Branch objDept = new domain.Branch();
                obj.Branch = objDept.GetRow(bid);
                TopicsMembers.Add(obj);
            }
            return TopicsMembers;
        }
    }
}
