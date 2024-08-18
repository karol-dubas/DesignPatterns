using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Zwraca rezultat do klienta, czyli np. to wideo
    /// </summary>
    public class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next) : base(next) { }

        public override void Handle(RequestContext requestContext)
        {
            requestContext.Response.IsSuccessful = true;
            requestContext.Response.Data = new object(); // wideo
        }
    }
}
