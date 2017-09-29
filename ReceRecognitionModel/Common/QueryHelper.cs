using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionModel
{
    public class QueryHelper
    {
        public static QueryResponse<T> SetResponse<T>(T obj)
        {
            QueryResponse<T> mr = new QueryResponse<T>();
            //mr.Http_Code ="200";
            mr.status = ServerErrorEnum.Normal;
            mr.info = "";
            mr.result = obj;
            return mr;
        }
    }
}
