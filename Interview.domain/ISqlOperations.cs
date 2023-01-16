using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.domain
{
   public interface ISqlOperations <T>
    {
        int Insert();
         int Update();
         int Delete();
         T GetRow(String id);
         List<T> GetRows();
    }
}
