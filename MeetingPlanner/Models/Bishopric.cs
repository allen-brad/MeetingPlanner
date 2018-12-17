using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Bishopric
    {
        
        public int BishopricID { get; set; }



        [Display(Name = "Name")]
        [StringLength(50, ErrorMessage = "Name can not be more than 50 characters. ")]
        [Required]
        public String name { get; set; }

        [Display(Name = "Position")]
        [StringLength(50, ErrorMessage = "Position can not be more than 50 characters. ")]
        [Required]
        public String position { get; set; }
    }
}
