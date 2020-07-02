using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Exception.Models
{
    public class BaseResultModel
    {
        public BaseResultModel(int? code = null, string message = null, object result = null, ReturnStatus returnStatus = ReturnStatus.Success)
        {
            this.Code = code;
            this.Message = message;
            this.Result = result;
            this.ReturnStatus = returnStatus;
        }

        public int? Code { get; set; }

        public string Message { get; set; }

        public object Result { get; set; }

        public ReturnStatus ReturnStatus { get; set; }
    }

    /// <summary>
    /// 返回状态
    /// </summary>
    public enum ReturnStatus
    {
        Fail = 0,
        Success = 1,
        ConfirmIsContinue = 2,
        Error = 3
    }
}
