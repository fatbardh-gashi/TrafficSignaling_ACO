using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSignaling_ACO.Entities
{
    public class Car
    {
        public List<Street> Path { get; set; }
        public int TimeToDestination { get; set; }
    }
}
