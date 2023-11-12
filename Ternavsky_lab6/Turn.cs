using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6
{
    internal class Turn
    {
        public int Distance { get; set; } 
        public string Direction { get; set; } 
        public string Location { get; set; }

        public Turn(int distance, string direction, string location)
        {
            Distance = distance;
            Direction = direction;
            Location = location;
        }
    }
}
