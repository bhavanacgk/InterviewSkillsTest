using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.domain
{
    public class Branch:ISqlOperations<Branch>
    {
        String ins_stmt,stmt;
        public int branchid { get; set; }
        public String name { get; set; }


        public int Insert()
        {
            ins_stmt = "insert into Branch values(";
            //ins_stmt += "'" + branchid + "'" + ",";
            ins_stmt += "'" + name + "'" + ");";            
            SqlHelper helper = new SqlHelper();
            return helper.DML(ins_stmt);

        }

        public int Update()
        {
            stmt = "Update Branch SET ";
            stmt += "name='" + name + "'" + ",";
            stmt += " where bid='" + branchid + "'";
            SqlHelper helper = new SqlHelper();
            return helper.DML(stmt);
        }

        public int Delete()
        {
            stmt = "delete Branch where bid ='" + branchid + "'";
            SqlHelper objSql = new SqlHelper();
            return objSql.DML(stmt); 
        }

        public Branch GetRow(string id)
        {
            stmt = "Select * from Branch where bid ='" + id + "'";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null)
                return null;
            Branch objbr = new Branch();
            objbr.branchid = int.Parse(dt.Rows[0]["bid"].ToString());
            objbr.name = dt.Rows[0]["name"].ToString();
            return objbr;
        }

        public List<Branch> GetRows()
        {
           ins_stmt = "Select * from Branch";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(ins_stmt);
            if (dt == null)
                return null;
            List<Branch> br = new List<Branch>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Branch objReg = new Branch();
                objReg.branchid = int.Parse(dt.Rows[i]["bid"].ToString());
                objReg.name = dt.Rows[i]["name"].ToString();
                br.Add(objReg);
            }
            return br;
        }
    }
}
