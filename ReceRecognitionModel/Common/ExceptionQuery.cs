using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace RecognitionModel
{
    public class ExceptionQuery
    {
        public static QueryResponse<T> SetException<T>(Exception ex)
        {
            QueryResponse<T> rValue = new QueryResponse<T>();
            if (ex is ApplicationException)
                rValue.status = ServerErrorEnum.ServiceError;//系统异常
            rValue.info = "服务未处理异常";
            rValue.result = default(T);
            Exception logException = ex;
            if (ex.InnerException != null)
                logException = ex.InnerException;
            return rValue;
        }
    }
}
