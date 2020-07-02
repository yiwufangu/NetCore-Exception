using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetCore.Exception.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Exception.Filters
{
    public class ValidationFailedResultModel : BaseResultModel
    {
        public ValidationFailedResultModel(ModelStateDictionary modelSate)
        {
            Code = 422;
            Message = "参数不合法";
            Result = modelSate.Keys.SelectMany(key => modelSate[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage))).ToList();
            ReturnStatus = ReturnStatus.Fail;
        }
    }
}
