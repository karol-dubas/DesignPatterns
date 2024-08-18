using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class RegisterClientView : IMediator
    {
        private Button _submitButton;
        private Checkbox _clientType;

        public RegisterClientView(Button submitButton, Checkbox clientType)
        {
            _submitButton = submitButton;
            _clientType = clientType;

            _submitButton.SetMediator(this);
            _clientType.SetMediator(this);
        }

        public void Notify(Component sender, string @event)
        {
            switch (@event)
            {
                case "checkbox selected":
                    _submitButton.Render();
                    break;
                case "button clicked":
                    _clientType.SaveValue();
                    break;
            }
        }
    }
}
