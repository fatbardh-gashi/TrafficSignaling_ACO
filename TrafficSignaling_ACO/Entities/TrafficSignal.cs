using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSignaling_ACO.Entities
{
    public class TrafficSignal
    {
        public Intersection Intersection { get; set; }
        public List<Street> Streets { get; set; }
        public List<int> Durations { get; set; }
    }
}
