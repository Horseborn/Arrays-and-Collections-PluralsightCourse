using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Collections_4__Dictionaries_
{
    class BusRouteRepository
    {

        public static Dictionary<int, BusRoute> InitializeRoutes()
        {


            BusRoute route40 = new BusRoute(40, new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" });
            BusRoute route42 = new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" });
            BusRoute route100 = new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" });
            BusRoute route555 = new BusRoute(555, new string[] { "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" });
            BusRoute route5 = new BusRoute(5, new string[] { "Overton", "Morecambe", "Carnforth" });


            var routes = new Dictionary<int, BusRoute>
            {
                { 40, route40 },
                { 42, route42 },
                { 100, route100 },
                { 555, route555 },
                { 5, route5 }
            };
            return routes;



            //var routes = new Dictionary<int, BusRoute>();
            //routes.Add(40, route40);
            //routes.Add(42, route42);
            //routes.Add(100, route100);
            //routes.Add(555, route555);
            //routes.Add(5, route5);
            //return routes;
        }
    }
}
