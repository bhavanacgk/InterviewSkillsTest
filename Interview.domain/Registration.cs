using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Interview.domain
{
    public class Registration : ISqlOperations<Registration>
    {

        String ins_stmt,stmt;

        public int registrationid { get; set; }
        public String mail { get; set; }
        public String pwd { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public String gender { get; set; }
        public String ph_no { get; set; }
        public DateTime dob { get; set; }


        public int Insert()
        {
            ins_stmt = "insert into Registration(mail,pwd,name,address,gender,ph_no,dob) values(";
           // ins_stmt += "'" + registrationid + "'" + ",";
            ins_stmt += "'" + mail + "'" + ",";
            ins_stmt += "'" + pwd + "'" + ",";
            ins_stmt += "'" + name + "'" + ",";
            ins_stmt += "'" + address + "'" + ",";
            ins_stmt += "'" + gender + "'" + ",";
            ins_stmt += "'" + ph_no + "'" + ",";
            ins_stmt += "'" + dob + "'" + ");";
            SqlHelper helper = new SqlHelper();
            return helper.DML(ins_stmt);
        }

        public int Update()
        {
            stmt = "Update Registration SET ";
            stmt += "name='" + name + "'" + ",";
            stmt += "address='" + address + "'" + ",";
            stmt += "dob='" + dob + "'" + ",";
            stmt += "ph_no='" + ph_no + "'" + ",";
            stmt += "mail='" + mail + "'";
            stmt += " where rid='" + registrationid + "'";
            SqlHelper helper = new SqlHelper();
            return helper.DML(stmt);
        }

        public int Delete()
        {
            stmt = "delete Registration where rid ='" + registrationid + "'"; 
            SqlHelper objSql = new SqlHelper();
            return objSql.DML(stmt); 
        }

        public Registration GetRow(string id)
        {
            stmt = "Select * from Registration where rid ='" + id + "'"; 
            SqlHelper objSql = new SqlHelper(); 
            System.Data.DataTable dt = objSql.GetData(stmt); 
            if (dt == null) 
                return null; 
            Registration objreg = new Registration(); 
            objreg.registrationid = int.Parse(dt.Rows[0]["rid"].ToString()); 
            objreg.name = dt.Rows[0]["name"].ToString();
            objreg.mail = dt.Rows[0]["mail"].ToString();
            objreg.ph_no = dt.Rows[0]["ph_no"].ToString();
            objreg.address = dt.Rows[0]["address"].ToString();
            objreg.dob = DateTime.Parse(dt.Rows[0]["dob"].ToString());
            return objreg; 
        }

        public List<Registration> GetRows()
        {
            ins_stmt = "Select * from Registration";
            SqlHelper objSql = new SqlHelper();
            System.Data.DataTable dt = objSql.GetData(ins_stmt);
            if (dt == null)
                return null;
            List<Registration> reg = new List<Registration>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Registration objReg = new Registration();
                objReg.registrationid = int.Parse(dt.Rows[i]["rid"].ToString());
                objReg.name = dt.Rows[i]["name"].ToString();
                objReg.mail = dt.Rows[i]["mail"].ToString();
                objReg.address = dt.Rows[i]["address"].ToString();
                objReg.ph_no = dt.Rows[i]["ph_no"].ToString();
                objReg.dob =DateTime.Parse(dt.Rows[i]["dob"].ToString());
                reg.Add(objReg);
            }
            return reg;
        }

        public int GetRecordCount()
        {
            stmt = "Select count(*) from Registration ";
            stmt += " where [name] = '" + name + "' and ";
            stmt += "pwd='" + pwd + "'";
            SqlHelper objSql = new SqlHelper();
            return objSql.GetRowCount(stmt);
        }
    }
}

