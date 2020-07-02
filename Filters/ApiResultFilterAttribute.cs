﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NetCore.Exception.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Exception.Filters
{
    public class ApiResultFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is ValidationFailedResult)
            {
                var objectResult = context.Result as ObjectResult;
                context.Result = objectResult;
            }
            else
            {
                var objectResult = context.Result as ObjectResult;
                context.Result = new OkObjectResult(new BaseResultModel(code: 200, result: objectResult.Value));
            }
        }
    }
}
