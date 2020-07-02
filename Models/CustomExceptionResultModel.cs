using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NetCore.Exception.Models
{
    public class CustomExceptionResultModel : BaseResultModel
    {
        public CustomExceptionResultModel(int? code, System.Exception exception)
        {
            Code = code;
            Message = exception.InnerException != null ?
                exception.InnerException.Message :
                exception.Message;
            Result = exception.Message;
            ReturnStatus = ReturnStatus.Error;
        }
    }
}
