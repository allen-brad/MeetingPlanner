using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Testimonies : MeetingContent
    {
        public int TestimoniesID { get; set; }
        public readonly string Description = "Bearing of Testimonies";
    }
}
