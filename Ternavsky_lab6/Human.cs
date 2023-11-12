using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6
{
    internal class Human
    {
        public double Speed { get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }
        public string Position { get; set; }
        public double Money { get; set; }


        public Human(string name, string position, string destination)
        {
            Name = name;
            Position = position;
            Destination = destination;
            Speed = 5.0; 
        }

        public void Move()
        { 
            
        }
    }
}
