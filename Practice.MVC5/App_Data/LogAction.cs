using Practice.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.MVC5.Actions
{
    public class LogAttribute : ActionFilterAttribute
    {
        private IDictionary<string, object> _parameters;
        public string Description { get; set; }

        public PersonContext PersonContext { get; set; }
        public LogAttribute(string description, PersonContext personContext)
        {
            Description = description;
            PersonContext = personContext;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _parameters = filterContext.ActionParameters;
            base.OnActionExecuting(filterContext);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            //  var userId = filterContext.HttpContext.User.Identity.GetUserId();
            // var user = 
            //use _paramters to get the input parameters
            foreach (var kvp in _parameters)
            {
                
            }
        }
    }
}