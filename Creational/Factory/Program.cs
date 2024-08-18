using Factory.Shapes;
using System;

namespace Factory
{
    class Program
    {
        // Fabryka to wzorzec, dzięki któremu udostępniane są metody do tworzenia klasy bazowej.
        // Pozwala podklasom zmieniać typ tworzonych obiektów.

        // Oddziela kod tworzący pewne obiekty, od kodu, który z nich korzysta.

        // Chcę stworzyć aplikację do tworzenia diagramów UML i flowchart.
        // Oba korzystają z kształtów jak koło, prostokąt...
        // Aby nie powielać kodu tworzenia kształtów, tworzę Fabrykę,
        // która udostępnia interfejs do tworzenia tych kształtów.

        static void Main(string[] args)
        {
            var circle = ShapeFactory.CreateShape(nameof(Circle));
            circle.Render();
        }
    }
}
