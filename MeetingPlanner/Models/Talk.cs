using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Talk
    {
        public int TalkID { get; set; }

        public int MeetingID { get; set; }
        public int SortOrder { get; set; }

        public String SpeakerFirstName { get; set; }
        public String SpeakerLastName { get; set; }
        public String Topic { get; set; }
        public Boolean Assigned { get; set; }
        public Boolean Accepted { get; set; }

        public Meeting Meeting { get; set; }

    }
}
