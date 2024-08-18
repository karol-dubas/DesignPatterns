using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Button : Component
    {
        public void Render()
        {
            Console.WriteLine("Rendering button");
        }

        public void Click()
        {
            Console.WriteLine("Button clicked");

            // Jeżeli ten komponent potrzebuje się skomunikować z innymi komponentami
            _mediator.Notify(this, "button clicked");
        }
    }
}
