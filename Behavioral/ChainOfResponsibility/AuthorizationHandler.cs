using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class AuthorizationHandler : BaseHandler
    {
        public AuthorizationHandler(IHandler next) : base(next) { }

        public override void Handle(RequestContext requestContext)
        {
            if (requestContext.Request.UserRole == "Admin")
            {
                // To możemy przekazać dalej
                _next.Handle(requestContext);
                return;
            }

            // Inaczej przerwij i wyślij odpowiedź, że próba nieudana
            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "User is not authorized";
        }
    }
}
