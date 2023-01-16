using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Interview.domain
{
    public class Admin : ISqlOperations <Admin>
    {
        String ins_stmt,stmt;

        public int adminid { get; set; }
        public String name { get; set; }
        public String pwd { get; set; }
        public String ph_no { get; set; }
        public String email { get; set; }


        public int Insert()
        {
            ins_stmt = "insert into Admin values(";
            ins_stmt += "'" + adminid + "'" + ",";
            ins_stmt += "'" + name + "'" + ",";
            ins_stmt += "'" + pwd + "'" + ",";
            ins_stmt += "'" + ph_no + "'" + ",";
            ins_stmt += "'" + email + "'" + ");";
            SqlHelper helper = new SqlHelper();
            return helper.DML(ins_stmt);
        }

        public int Update()
        {
            stmt = "Update Admin SET ";
            //stmt += "adminid='" + adminid + "'" + ",";
            stmt += "name='" + name + "'" + ",";
            stmt += "pwd='" + pwd + "'" + ",";
            stmt += "ph_no='" + ph_no + "'" + ",";
            stmt += "email='" + email + "'" + ";";
            SqlHelper helper = new SqlHelper();
            return helper.DML(stmt);
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }

        public Admin GetRow(string adminid)
        {
            stmt = "Select * from Admin where adminid ='" + adminid + "'";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null)
                return null;
            Admin objadmin = new Admin();
            //objadmin.adminid = dt.Rows[0]["adminid"].ToString();
            objadmin.name = dt.Rows[0]["name"].ToString();
            return objadmin;
        }

        public List<Admin> GetRows()
        {
            stmt = "Select * from Admin";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(stmt);
            if (dt == null)
                return null;
            List<Admin> admin = new List<Admin>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Admin objAdmin = new Admin();
                //objAdmin.adminid = dt.Rows[i]["adminid"].ToString();
                objAdmin.name = dt.Rows[i]["name"].ToString();
                admin.Add(objAdmin);
            }
            return admin;        
        }
        public int GetRecordCount()
        {
            stmt = "Select count(*) from Admin ";
            stmt += " where [name] = '" + name + "' and ";
            stmt += "pwd='" + pwd + "'";
            SqlHelper objSql = new SqlHelper();
            return objSql.GetRowCount(stmt);
        }
    }
}
