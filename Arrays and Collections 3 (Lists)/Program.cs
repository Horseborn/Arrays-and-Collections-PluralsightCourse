using System;
using System.Collections.Generic;

namespace Arrays_and_Collections_3__Lists_
{
    class Program
    {
        static void Main(string[] args)
        {
            //comparing arrays and lists
            //array - T[] : Fixed size, instantiate with the fixed number of elements. Cannot be changed after this. Whilst arrays are built into the language,
            //thus making the syntax somewhat easier
            //list - List<T> : Not a fixed size. Instantiate empty, then add the elements you need. Has the extra ability to add and remove items.
            //Use list if you need to dynamically add and remove items after instantiation, but use an array if you won't need to do that. 
            

            List<BusRoute>allRoutes = BusRouteRepository.InitializeRoutes();

            Console.WriteLine($"Before RemoveAt: There are {allRoutes.Count} routes:");
            foreach (BusRoute route in allRoutes)
            {
                Console.WriteLine($"Route: {route}");
            }

            allRoutes.RemoveAll(route => route.Origin.StartsWith("Test"));

            Console.WriteLine($"\r\nAfter RemoveAt: There are {allRoutes.Count} routes:");
            foreach (BusRoute route in allRoutes)
            {
                Console.WriteLine($"Route: {route}");
            }
        }
    }
}

/* Summary:
 * Arrays are a fixed size.
 * Can't add or remove elements.
 * Array.Resize() actually copies the array
 * 
 * Lists are similar to arrays but not a fixed size.
 * But lists are not optimised for frequent adding and/or removing
 */