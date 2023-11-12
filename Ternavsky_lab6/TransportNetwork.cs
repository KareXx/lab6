using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6
{
    internal class TransportNetwork
    {
        public List<Route> map = new List<Route>();

        public void AddRoat(Route route)
        { 
            map.Add(route);
        }

        public Route ShortestWay(Human person)
        { 
            foreach (Route route in map) 
            { 
                foreach(Turn route2 in route.Turns) 
                {
                    if (person.Destination == route2.Location)
                    {
                        return route;
                    }
                }
            }
            return null;
        }
        public Route PersonWay(Human person)
        {
            foreach (Route route in map)
            {
                foreach (Turn route2 in route.Turns)
                {
                    if (person.Position == route2.Location)
                    {
                        return route;
                    }
                }
            }
            return null;
        }

        public int Distance(Human person)
        {
            Route wayList = ShortestWay(person);
            Route personPositionWay = PersonWay(person);
            int sum = 0;


            if ((wayList != null) && (personPositionWay != null))
            {
                foreach (Turn turn in personPositionWay.Turns)
                {
                    if (person.Position == turn.Location)
                    {
                        break;
                    }
                    sum += turn.Distance;

                }
                foreach (Turn turn in wayList.Turns)
                {
                    if (person.Destination == turn.Location)
                    {
                        break;
                    }
                    sum += turn.Distance;
                }
                return sum;
            }
            else
            {
                return -1;
            }
        }
    }
}
