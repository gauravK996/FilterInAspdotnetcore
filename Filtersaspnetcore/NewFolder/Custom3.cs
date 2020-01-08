using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtersaspnetcore.NewFolder
{
    public class Custom3 : TypeFilterAttribute
    {
        public Custom3(int Name,string id) : base(typeof(MoreFilterAttribute))
        {
            this.Arguments = new object[] { Name,id };
        }
        public class MoreFilterAttribute:IActionFilter
        {

            private readonly int _name;
            private readonly string _id;
            public MoreFilterAttribute(int name,string id)
            {
                this._name = name;
                this._id = id;
            }
            public void OnActionExecuting(ActionExecutingContext actionExecutingContext)
            {
                actionExecutingContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary {
                        { "Controller","Home"},
                        { "Action","index"},
                        {"id",_name },
                        {"name",_id }
                    }
                    );
                
            }
            public void OnActionExecuted(ActionExecutedContext actionExecutedContext)
            {

            }
        }
    }
}
