using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Talk : MeetingContent
    {
        public int TalkID { get; set; }

        public String SpeakerFirstName { get; set; }
        public String SpeakerLastName { get; set; }
        public String Topic { get; set; }
        public Boolean Assigned { get; set; }
        public Boolean Accepted { get; set; }

    }
}
