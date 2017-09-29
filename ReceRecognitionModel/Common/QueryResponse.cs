using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionModel
{
    public class QueryResponse<T>
    {
        public QueryResponse()
        {
            servertime = DateTime.Now;  
        }

        //public string Http_Code { get; set; }
        /// <summary>
        /// 错误代码 0或者空正常 1服务内部异常 2服务安全校验失败，3业务异常
        /// </summary>
        public ServerErrorEnum status { set; get; }

        

        public string info { set; get; }

        public T result { set; get; }

        public string errordata { get; set; }

        public DateTime servertime { get; set; }

    }
    public class ServerError
    {
        private static Dictionary<string, string> dicServerError = new Dictionary<string, string>();
        public Dictionary<string, string> GetServerError()
        {
            if (dicServerError.Count > 0) return dicServerError;
            dicServerError.Add("0", "正常");
            dicServerError.Add("1", "服务内部异常");
            dicServerError.Add("2", "服务安全校验失败");
            dicServerError.Add("3", "业务异常");
            return dicServerError;
        }
    }
}
