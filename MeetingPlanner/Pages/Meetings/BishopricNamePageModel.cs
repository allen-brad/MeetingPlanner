using MeetingPlanner.Data;

using MeetingPlanner.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MeetingPlanner.Pages.Meetings
{
    public class BishopricNamePageModel : PageModel
    {
        public SelectList BishopricNameSL { get; set; }

        public void PopulateConductingDropDownList(MeetingContext _context,
            object selectedMember = null)
        {
            var memberQuery = from d in _context.Bishopric
                              orderby d.name // Sort by name.
                              select d;

            BishopricNameSL = new SelectList(memberQuery.AsNoTracking(),
                        "BishopricID", "name", selectedMember);
        }

    }
}
