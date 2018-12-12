using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    //public enum MusicDescription
    //{
    //    [DescriptionAttribute("Opening Hymn")] OpeningHymn,
    //    [DescriptionAttribute("Sacrament Hymn")] SacramentHymn,
    //    [DescriptionAttribute("Intermediate Hymn")] IntermediateHymn,
    //    [DescriptionAttribute("Closing Hymn")] ClosingHymn,
    //    Other
    //}
    public class MusicalNumber
    {
        public int MusicalNumberID { get; set; }
        public int MeetingID { get; set; }

        [Required]
        public String Description { get; set; }
        [Display(Name = "Sort Order")]
        public int SortOrder { get; set; }

        [Display(Name = "Hymn Number")]
        public int HymnNumber { get; set; }

        [Required]
        [StringLength(50)]
        public String Title { get; set; }
        [StringLength(50)]
        public String Performers { get; set; }
        [StringLength(50)]
        public String Accompaniement { get; set; }

        public Meeting Meeting { get; set; }

    }
}
