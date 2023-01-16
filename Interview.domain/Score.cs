using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Interview.domain
{
    public class Score:ISqlOperations<Score>
    {
        String ins_stmt;
        public int scoreid { get; set; }
        public int registrationid { get; set; }
        public int score { get; set; }


        public int Insert()
        {
            ins_stmt = "insert into Score values(";
            ins_stmt += "'" + scoreid + "'" + ",";
            ins_stmt += "'" + registrationid + "'" + ",";
            ins_stmt += "'" + score + "'" + ");";
            SqlHelper helper = new SqlHelper();
            return helper.DML(ins_stmt);
        }

        public int Update()
        {
            throw new NotImplementedException();
        }

        public int Delete()
        {
            throw new NotImplementedException();
        }

        public Score GetRow(string id)
        {
            throw new NotImplementedException();
        }

        public List<Score> GetRows()
        {
            throw new NotImplementedException();
        }
    }
}
