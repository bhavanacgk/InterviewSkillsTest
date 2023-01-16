using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Interview.domain
{
    public class Answer:ISqlOperations<Answer>
    {
        String ins_stmt;
        public int answerid { get; set; }
        public int quesid { get; set; }
        public int registrationid { get; set; }
        public String answer { get; set; }


        public int Insert()
        {
            ins_stmt = "insert into Answer values(";
            ins_stmt += "'" + answerid + "'" + ",";
            ins_stmt += "'" + quesid + "'" + ",";
            ins_stmt += "'" + answer + "'" + ",";
            ins_stmt += "'" + registrationid + "'" + ");";
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

        public Answer GetRow(string id)
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetRows()
        {
            throw new NotImplementedException();
        }
    }
}
