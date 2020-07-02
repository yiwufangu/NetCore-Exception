using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Exception.Filters
{
    public class CustomExceptionAttribute : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            System.Net.HttpStatusCode status = System.Net.HttpStatusCode.InternalServerError;

            // 处理异常
            if (!context.ExceptionHandled)
            {

            }

            context.ExceptionHandled = true;

            context.Result = new NetCore.Exception.Models.CustomExceptionResult((int)status, context.Exception);
        }
    }
}
