using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;
using Microsoft.AspNetCore.Authorization;

namespace MeetingPlanner.Pages.Meetings
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public EditModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FindAsync(id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var meetingToUpdate = await _context.Meeting.FindAsync(id);

            // _context.Attach(Meeting).State = EntityState.Modified;
            if (await TryUpdateModelAsync<Meeting>(
                meetingToUpdate,
                "meeting",   // Prefix for form value.
                m => m.Date, m => m.Choirister, m => m.Organist, m => m.Invocation, m => m.Presiding, m => m.Conducting,
                m => m.Announcements, m => m.WardBusiness, m => m.StakeBusiness, m => m.Benediction))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}
