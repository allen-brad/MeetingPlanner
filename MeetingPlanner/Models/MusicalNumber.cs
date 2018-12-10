using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class MusicalNumber : MeetingContent
    {
        public int MusicalNumberID { get; set; }
        public String Title { get; set; }
        public String Performers { get; set; }
        public String Accompaniement { get; set; }

    }
}
