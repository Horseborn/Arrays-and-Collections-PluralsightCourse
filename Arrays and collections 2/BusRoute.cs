﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_collections_2
{
    class BusRoute
    {
        public int Number { get; }
        public string Origin => PlacesServed[0];
        public string Destination => PlacesServed[^1];
        public string[] PlacesServed { get; }

        public BusRoute(int number, string[] PlacesServed)
        {
            Number = number;
            this.PlacesServed = PlacesServed;
        }

        public override string ToString() => $"{Number}: {Origin} -> {Destination}";
        
        public bool Serves(string destination)
        {
            return Array.Exists(PlacesServed, place => place == destination);
            
            //foreach (string place in PlacesServed)
            //{
            //    if (place == destination)
            //        return true;
            //} return false;

        }    
        
    }
}
