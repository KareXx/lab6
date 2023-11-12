using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6
{
    internal class Car: Vehicle
    {
        public double Fare { get; set; }
        public List<Human> passengers = new List<Human>();

        public Car(double speed, int capacity, double fare)
        {
            if (passengers.Count > capacity)
            {
                Console.WriteLine("Слишком много пассажиров");
                throw new ArgumentException("Слишком много пассажиров");
            }
            Speed = speed;
            Capacity = capacity;
            Fare = fare;
        }

        public override void Move()
        {
            Human firstInLine = null;
            int min_distance = 0;
            

            foreach (Human passanger in passengers)
            {
                if (min_distance > TransportNetwork.Distance(passanger)) // В чому тут помилка?
                {
                    min_distance = TransportNetwork.Distance(passanger);
                    firstInLine = passanger;
                }
            }

            Console.WriteLine("Иашина їде зі швидкістю " + Speed + " км/год. Наступинка зупинка" + firstInLine.Destination + ". До виходу готується" + firstInLine.Name);
            passengers.Remove(firstInLine);
        }
    }
}
