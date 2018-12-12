using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Meeting
    {
        public int MeetingID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [StringLength(50, ErrorMessage = "Choirister name cannot be longer than 50 characters.")]
        public String Choirister { get; set; }

        [StringLength(50, ErrorMessage = "Organist name cannot be longer than 50 characters.")]    
        public String Organist { get; set; }

        [StringLength(50, ErrorMessage = "Invocation name cannot be longer than 50 characters.")]
        public String Invocation { get; set; }

        [StringLength(50, ErrorMessage = "Presiding name cannot be longer than 50 characters.")]
        public String Presiding { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Conducting name cannot be longer than 50 characters.")]
        public String Conducting { get; set; }

        public String Announcements { get; set; }
        [Display(Name = "Ward Business")]
        public String WardBusiness { get; set; }

        [Display(Name = "State Business")]
        public String StakeBusiness { get; set; }

        [StringLength(50, ErrorMessage = "Beneditcion name cannot be longer than 50 characters.")]
        public String Benediction { get; set; }


        public ICollection<MusicalNumber> MusicalNumbers { get; set; }
        public ICollection<Talk> Talks { get; set; }
        public virtual Testimonies Testimonies { get; set; }

    }
}
