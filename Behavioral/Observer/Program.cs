using System;

namespace Observer
{
    class Program
    {
        // Obserwator pozwala na utworzenie subskrypcji i powiadamianie subskrybentów.

        // Chcę otrzymywać powiadomienia, kiedy produkt będzie dostępny w sklepie.

        static void Main(string[] args)
        {
            var subscriber1 = new Subscriber("Karol");
            var subscriber2 = new Subscriber("Adam");

            var publisher = new Publisher();
            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);
            publisher.Notify("test notify");
        }
    }
}
