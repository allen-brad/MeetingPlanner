using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Talk
    {
        public int TalkID { get; set; }

        public int MeetingID { get; set; }

        [Display(Name = "Sort Order")]
        public int SortOrder { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public String SpeakerFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public String SpeakerLastName { get; set; }

        [Required]
        [StringLength(50)]
        public String Topic { get; set; }

        [Required]
        public Boolean Assigned { get; set; }
        [Required]
        public Boolean Accepted { get; set; }

        public Meeting Meeting { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return SpeakerFirstName + " " + SpeakerLastName;
            }
        }

    }
}
