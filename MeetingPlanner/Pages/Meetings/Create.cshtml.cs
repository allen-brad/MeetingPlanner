using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MeetingPlanner.Models;

namespace MeetingPlanner.Pages.Meetings
{
    public class CreateModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public CreateModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meeting Meeting { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyMeeting = new Meeting();

            if (await TryUpdateModelAsync<Meeting>(
                emptyMeeting,
                "meeting",   // Prefix for form value.
                m => m.Date, m => m.Choirister, m => m.Organist, m => m.Invocation, m => m.Presiding, m => m.Conducting,
                m => m.Announcements, m => m.WardBusiness, m => m.StakeBusiness, m => m.Benediction))
            {
                _context.Meeting.Add(emptyMeeting);
                await _context.SaveChangesAsync();         
                return RedirectToPage("./Index");
            }
            return null;
        }
    }
}