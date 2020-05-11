using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Passenger> paxList = Passenger.LoadPassengers();

            List<Passenger> survivor = paxList.FindAll(p => p.Survivor);
            foreach (var pax in survivor)
            {
                Console.WriteLine(pax);
            }
        }
    }
}
