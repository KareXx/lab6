using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6
{
    internal class Bus: Vehicle
    {
        public Route Route { get; set; }
        public List<Human> passengers = new List<Human>();

        public Bus(double speed, int capacity , Route route)
        {
            if (passengers.Count > capacity)
            {
                Console.WriteLine("Слишком много пассажиров");
                throw new ArgumentException("Слишком много пассажиров");
            }
            Speed = speed;
            Capacity = capacity;
            Route = route;
        }

        public override void Move()
        {
            foreach (Turn nextStation in Route.Turns)
            {
                Console.WriteLine("Наступна зупинка" + nextStation.Location + ". До виходу готується:");

                foreach (Human passanger in passengers)
                {
                    if (passanger.Destination == nextStation.Location)
                    {
                        Console.WriteLine(passanger.Name);
                        passengers.Remove(passanger);
                    }
                }
            }
            Console.WriteLine("Train is moving at a speed of " + Speed + " km/h.");
        }
    }
}
