using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Meeting
    {
        public int MeetingID { get; set; }
        public DateTime Date { get; set; }
        public String OpeningHymn { get; set; }
        public String Choirister { get; set; }
        public String Organist { get; set; }
        public String Invocation { get; set; }
        public String Announcements { get; set; }
        public String Presiding { get; set; }
        public String Conducting { get; set; }
        public String WardBusiness { get; set; }
        public String StakeBusiness { get; set; }

        public ICollection<MeetingContent> Content { get; set; }

        public String ClosingHymn { get; set; }
        public String Benediction { get; set; }

    }
}
