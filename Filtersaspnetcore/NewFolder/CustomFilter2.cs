using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtersaspnetcore.NewFolder
{
    public class CustomFilter2 : Attribute, IFilterFactory
    {
        public bool IsReusable { 
        get {
            return false;
            }
            }

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            return new InternalFilter();
        }
        public class InternalFilter : IActionFilter
        {
            public void OnActionExecuting(ActionExecutingContext actionExecutingContext)
            {
                actionExecutingContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary {
                        { "Controller","Home"},
                        { "Action","index"}
                    }
                    );
            }
            public void OnActionExecuted(ActionExecutedContext actionExecutedContext)
            {

            }
        }
    }
}
