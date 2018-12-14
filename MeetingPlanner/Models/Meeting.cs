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
        [Display(Name = "Meeting Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [StringLength(50, ErrorMessage = "Choirister name cannot be longer than 50 characters.")]
        public String Choirister { get; set; }
        [Display(Name = "Organist/Pianist")]
        [StringLength(50, ErrorMessage = "Organist name cannot be longer than 50 characters.")]    
        public String Organist { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Invocation name cannot be longer than 50 characters.")]
        public String Invocation { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Presiding name cannot be longer than 50 characters.")]
        public String Presiding { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Conducting name cannot be longer than 50 characters.")]
        public String Conducting { get; set; }

        public String Announcements { get; set; }
        [Display(Name = "Ward Business")]
        public String WardBusiness { get; set; }

        [Display(Name = "Stake Business")]
        public String StakeBusiness { get; set; }
        [Required]
        [Display(Name = "Opening Hymn")]
        [StringLength(50, ErrorMessage = "Opening Hymn name cannot be longer than 50 characters.")]
        public String OpenHymn { get; set; }
        [Required]
        [Display(Name = "Sacrament Hymn")]
        [StringLength(50, ErrorMessage = "Sacrament Hymn name cannot be longer than 50 characters.")]
        public String SacHymn { get; set; }
        [StringLength(50, ErrorMessage = "Intermediate Hymn name cannot be longer than 50 characters.")]
        [Display(Name = "Intermediate Hymn")]
        public String IntHymn { get; set; }
        [Required]
        [Display(Name = "Closing Hymn")]
        [StringLength(50, ErrorMessage = "Closing Hymn name cannot be longer than 50 characters.")]
        public String CloseHymn { get; set; }
        [Display(Name = "1st Speaker Name")]
        [StringLength(50, ErrorMessage = "Speaker Name cannot be longer than 50 characters.")]
        public String TalkName1 { get; set; }
        [Display(Name = "Subject")]
        [StringLength(50, ErrorMessage = "Speaker Subject cannot be longer than 50 characters.")]
        public String TalkSubj1 { get; set; }
        [Display(Name = "2nd Speaker Name")]
        [StringLength(50, ErrorMessage = "Speaker Name cannot be longer than 50 characters.")]
        public String TalkName2 { get; set; }
        [Display(Name = "Subject")]
        [StringLength(50, ErrorMessage = "Speaker Subject cannot be longer than 50 characters.")]
        public String TalkSubj2 { get; set; }
        [Display(Name = "3rd Speaker Name")]
        [StringLength(50, ErrorMessage = "Speaker Name cannot be longer than 50 characters.")]
        public String TalkName3 { get; set; }
        [Display(Name = "Subject")]
        [StringLength(50, ErrorMessage = "Speaker Subject cannot be longer than 50 characters.")]
        public String TalkSubj3 { get; set; }
        [Display(Name = "4th Speaker Name")]
        [StringLength(50, ErrorMessage = "Speaker Name cannot be longer than 50 characters.")]
        public String TalkName4 { get; set; }
        [Display(Name = "Subject")]
        [StringLength(50, ErrorMessage = "Speaker Subject cannot be longer than 50 characters.")]
        public String TalkSubj4 { get; set; }
        [Display(Name = "5th Speaker Name")]
        [StringLength(50, ErrorMessage = "Speaker Name cannot be longer than 50 characters.")]
        public String TalkName5 { get; set; }
        [Display(Name = "Subject")]
        [StringLength(50, ErrorMessage = "Speaker Subject cannot be longer than 50 characters.")]
        public String TalkSubj5 { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Beneditcion name cannot be longer than 50 characters.")]
        public String Benediction { get; set; }


        public ICollection<MusicalNumber> MusicalNumbers { get; set; }
        public ICollection<Talk> Talks { get; set; }
        public virtual Testimonies Testimonies { get; set; }

    }
}
