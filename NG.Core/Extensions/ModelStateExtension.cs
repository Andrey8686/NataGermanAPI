using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NG.Core.Models;

namespace NG.Core.Extensions
{
    public static class ModelStateExtension
    {

        public static ErrorViewModels ToBadRequest(this ModelStateDictionary ms)
        {
            return new ErrorViewModels
            {
                errors = ms.ToDictionary(x => x.Key, x => x.Value.Errors.Select(e => e.ErrorMessage).ToList()),
                title = "One or more validation errors occurred.",
                status = 400,
                traceId = "8000000e-0001-ff00-b63f-84710c7967bb"
            };
        }
    }
}
