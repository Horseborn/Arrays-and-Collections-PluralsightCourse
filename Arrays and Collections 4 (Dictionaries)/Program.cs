using System;
using System.Collections.Generic;

namespace Arrays_and_Collections_4__Dictionaries_
{
    class Program
    {
        //Arrays and Lists are designed for index-based look-up and enumerating
        //Dictionaries are designed for finding items 
        static void Main(string[] args)
        {
            var allRoutes = BusRouteRepository.InitializeRoutes();

            
            //We say "allRoutes.Values" because we want the values, and not the keys. Dictionaries contain both
            foreach(BusRoute route in allRoutes.Values)
            {
                Console.WriteLine(route);
            }
            
            
            
            
            //Console.WriteLine("Which route do you want to look up?");
            //int number = int.Parse(Console.ReadLine());

            //BusRoute answer = allRoutes[number];

            //TryGetValue() looks up an item and returns a boolean to indicate sucess
            //bool sucess = allRoutes.TryGetValue(number, out BusRoute answer);

            //ContainsKey() checks to see whether the dictionary contains an item with the specified key and returns a boolean
            //bool sucess = allRoutes.ContainsKey(number);

            //if (sucess)
            //{
            //    Console.WriteLine($"The route you asked for is {allRoutes[number]}");
            //}else
            //    Console.WriteLine($"The is no route with number {number}");

            //This doesn't require searching, so this will be fast - even for very large collections
            //Array.Find() and List.Find() would be slow for large collections
        }
    }
}
