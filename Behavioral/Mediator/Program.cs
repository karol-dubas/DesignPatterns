using System;

namespace Mediator
{
    class Program
    {
        // Mediator redukuje zależności między obiektami. Obiekty komunikują się za pomocą obiektu mediatora.

        static void Main(string[] args)
        {
            var button = new Button();
            var checkbox = new Checkbox();

            new RegisterClientView(button, checkbox);

            // Użytkownik np. klika przycisk, a checkbox zostaje powiadomiony
            button.Click();

            // Tak samo tu
            checkbox.Select();
        }
    }
}
