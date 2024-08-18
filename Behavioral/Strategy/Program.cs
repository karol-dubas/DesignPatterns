using System;

namespace Strategy
{
    class Program
    {
        // Strategia umożliwia uruchamianie różnych wariantów algorytmu, w trakcie działania programu, który
        // ma te same dane wejściowe. Izoluje logikę biznesową od implementacji konkretnego algorytmu.

        // Chcę stowrzyć aplikację, która będzie mnie nawigować do wybranych punktów od miejsca w którym
        // się znajduję (Google Maps). Chcę mieć wybór w poruszaniu się autem, rowerem, pieszo i od tego,
        // co wybiorę będzie dobierana odpowiednia trasa.

        static void Main(string[] args)
        {
            var strategy = new CarStrategy();

            var map = new Map(strategy);
            map.CreateRoute(new Coordinate(1, 1), new Coordinate(5, 5));
        }
    }
}
