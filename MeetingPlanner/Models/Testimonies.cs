using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Testimonies
    {
        public int TestimoniesID { get; set; }
        public int MeetingID { get; set; }

        public readonly string Description = "Bearing of Testimonies";

        public Meeting Meeting { get; set; }
    }
}
