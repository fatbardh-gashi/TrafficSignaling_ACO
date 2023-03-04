using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSignaling_ACO.Entities
{
    public class Street
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public Intersection StartIntersection { get; set; }
        public Intersection EndIntersection { get; set; }
        public List<Car> Cars { get; set; }
        public TrafficSignal TrafficSignal { get; set; }
    }
}
