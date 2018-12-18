using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Testimonies
    {
        [Key]
        public int MeetingID { get; set; }

        public readonly string Description = "Bearing of Testimonies";

        public Meeting Meeting { get; set; }
    }
}
