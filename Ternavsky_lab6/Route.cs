using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6
{
    internal class Route
    {
        public List<Turn> Turns { get; set; }
        public bool Railway { get; set; }

        public Route(bool railway)
        {
            Turns = new List<Turn>();
            Railway = railway;
        }

        public void AddTurn(int distance, string direction, string location)
        {
            Turns.Add(new Turn(distance, direction, location));
        }

        public void DisplayMap()
        {
            foreach (var turn in Turns)
            {
                Console.WriteLine($"At {turn.Distance} meters, turn {turn.Direction} at {turn.Location}");
            }
        }
    }
}
