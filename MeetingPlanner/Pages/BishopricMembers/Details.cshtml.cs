using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;
using Microsoft.AspNetCore.Authorization;

namespace MeetingPlanner.Pages.BishopricMembers
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public DetailsModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public Bishopric Bishopric { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bishopric = await _context.Bishopric.FirstOrDefaultAsync(m => m.BishopricID == id);

            if (Bishopric == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
