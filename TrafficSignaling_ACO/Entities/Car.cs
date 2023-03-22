using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSignaling_ACO.Entities
{
    public class Car
    {
        public int NumStreets { get; set; }
        public List<string> Path { get; set; }
        public Intersection StartIntersection;
    }
}
