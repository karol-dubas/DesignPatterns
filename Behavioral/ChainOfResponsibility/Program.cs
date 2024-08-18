using System;

namespace ChainOfResponsibility
{
    class Program
    {
        // Łańcuch zobowiązań przekazuje żądania wszystkim obiektom w łańcuchu. Każdy taki obiekt może to
        // żądanie przetworzyć lub przekazać dalej. Można to porównać do łańcucha bloków if, while.

        // Mam aplikację, z której użytkownicy mogą korzystać poprzez oglądanie wideo, ale zanim wideo zostanie
        // udostępnione, muszę sprawdzić np. czy taki użytkownik jest zalogowany i ma do niego dostęp, w każdym
        // kroku mogę anulować takie żądanie.

        static void Main(string[] args)
        {
            // Init chain
            var resultHandler = new ResultHandler(null);
            var validationHandler = new ValidationHander(resultHandler);
            var authorizationHandler = new AuthorizationHandler(validationHandler);

            var requestContext = new RequestContext()
            {
                Request = new Request()
                {
                    UserId = 1,
                    EntityId = 101,
                    UserRole = "Admin"
                },
                Response = new Response()
            };

            authorizationHandler.Handle(requestContext);
        }
    }
}
