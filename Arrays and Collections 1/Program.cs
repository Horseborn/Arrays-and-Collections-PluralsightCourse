using System;

namespace Arrays_and_Collections_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
            BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

            BusRoute[] routes =
            {
                route40,
                route42,
                new BusRoute(100, "University", "Morecambe"),
                new BusRoute(555, "Lancaster", "Keswick")
                
            };

            BusRoute[] rute = new BusRoute[4];

            rute[0] = route40;
            rute[1] = route42;
            rute[2] = new BusRoute(100, "University", "Morecambe");
            rute[3] = new BusRoute(555, "Lancaster", "Keswick");





        }
    }
}

            //Console.WriteLine(routes[2]);
            //BusRoute rute1 = routes[0];
            //Console.WriteLine($"The third route is  {routes[2]}");
            //BusRoute lastroute = routes[routes.Length - 1];
            //up arrow 1 means the same as routes[routes.Length - 1]; in this case, remember this! 
            //BusRoute alterRoute = routes[^1];
            //Console.WriteLine(alterRoute);
            //Console.WriteLine(lastroute);
            //for (int i = 0; i < routes.Length; i++)
            //{
            //    Console.WriteLine($"{i}:{routes[i]}");
            //}
            //foreach (BusRoute route in routes)
            //{
            //    Console.WriteLine(route);
            //}