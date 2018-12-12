using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public String Description { get; set; }
        public int SortOrder { get; set; }
        public int HymnNumber { get; set; }
        public String Title { get; set; }
        public String Performers { get; set; }
        public String Accompaniement { get; set; }

        public Meeting Meeting { get; set; }

    }
}
