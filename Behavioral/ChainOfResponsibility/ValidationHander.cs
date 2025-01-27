﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ValidationHander : BaseHandler
    {
        public ValidationHander(IHandler next) : base(next) { }

        public override void Handle(RequestContext requestContext)
        {
            if (requestContext.Request.EntityId > 100)
            {
                _next.Handle(requestContext);
                return;
            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "Validation error: EntityId must be greater than 100";
        }
    }
}
