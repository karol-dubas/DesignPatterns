using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Map
    {
        private readonly IRouteStrategy _routeStrategy;

        public Map(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        // Strategia/algorytm nie jest tutaj implementowana na sztywno, każda klasa krtóra implementuje
        // IRouteStrategy może być tu dodana, np. trasa autobusem

        public void CreateRoute(Coordinate start, Coordinate end)
        {
            _routeStrategy.CreateRoute(start, end);
        }
    }
}
