using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Filtersaspnetcore.NewFolder
{
    public class CustomFilter:IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext actionExecutingContext)
        {
            actionExecutingContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary {
                    {"Controller","Home" },
                    { "Action","Index"}
                }
                );
            
        }
        public void OnActionExecuted(ActionExecutedContext actionExecutedContext)
        {

        }
    }
}
