using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    ///  Ta klasa agreguje zapytania użytkownika i odpowiedź, która zostanie zwrócona
    /// </summary>
    public class RequestContext
    {
        public Request Request { get; set; }
        public Response Response { get; set; }
    }

    public class Request
    {
        public long UserId { get; set; }
        public string UserRole { get; set; }
        public long EntityId { get; set; }
    }

    public class Response
    {
        public bool IsSuccessful { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
