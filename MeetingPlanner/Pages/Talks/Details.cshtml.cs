using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;

namespace MeetingPlanner.Pages.Talks
{
    public class DetailsModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public DetailsModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public Talk Talk { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Talk = await _context.Talk
                .Include(t => t.Meeting).FirstOrDefaultAsync(m => m.TalkID == id);

            if (Talk == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
