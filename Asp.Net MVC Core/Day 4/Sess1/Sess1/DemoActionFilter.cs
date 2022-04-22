using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sess1
{
    public class DemoActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        { //After Action method is called
                        
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        { //Before Action method is called
            if (context.HttpContext.Request.Scheme == "http")
            {
                //Stop the action if not via SSL
                context.Result = new StatusCodeResult(404);
            }
        }
    }
}
