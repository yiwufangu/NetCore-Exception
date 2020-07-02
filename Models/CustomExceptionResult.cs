using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Exception.Models
{
    public class CustomExceptionResult : ObjectResult
    {
        public CustomExceptionResult(int? code, System.Exception exception) : base(new CustomExceptionResultModel(code, exception))
        {
            StatusCode = code;
        }
    }
}
