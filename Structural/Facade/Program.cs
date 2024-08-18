using System;

namespace Facade
{
    class Program
    {
        // Fasada ma za zadanie utworzenie interefjsu dla zestawu klas. Łączy klasy tak, żeby nie było widać wszystkich
        // funkcjonalności podczas wykonywania jakiegoś algorytmu, a żeby klient otrzymał jedynie np. prostą metodę.

        static void Main(string[] args)
        {
            var scanFacade = new ScanFacade();
            scanFacade.Scan("https://github.com");
        }
    }
}
