using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionModel
{
    public enum ServerErrorEnum
    {
        Normal = 0,
        //
        // 摘要: 
        //     服务异常
        ServiceError = 1,
        //
        // 摘要: 
        //     登录异常
        LoginError = 2,
        //
        // 摘要: 
        //     tocken验证失败
        TokenError = 3,
        //
        // 摘要: 
        //     业务异常
        BusError = 4,
        NotModified = 304,
        BadRequest = 400,
        Forbidden = 403,
    }
}
