using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MeetingPlanner.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace MeetingPlanner.Pages.Meetings
{
    [Authorize]

    public class CreateModel : BishopricNamePageModel//PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public CreateModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Meeting Meeting { get; set; }
        public IActionResult OnGet()
        {
            PopulateConductingDropDownList(_context);
            return Page();
        }

        //[BindProperty]
        //public Meeting Meeting { get; set; }

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
                m => m.Date, m => m.Choirister, m => m.Organist, m => m.Invocation, m => m.Presiding, m => m.BishopricID,
                m => m.Announcements, m => m.WardBusiness, m => m.StakeBusiness,
                m => m.OpenHymn, m => m.SacHymn, m => m.IntHymn, m => m.CloseHymn,
                m => m.TalkName1, m => m.TalkSubj1,
                m => m.TalkName2, m => m.TalkSubj2,
                m => m.TalkName3, m => m.TalkSubj3,
                m => m.TalkName4, m => m.TalkSubj4,
                m => m.TalkName5, m => m.TalkSubj5,
                m => m.Benediction))
            {
                _context.Meeting.Add(emptyMeeting);
                await _context.SaveChangesAsync();         
                return RedirectToPage("./Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            //PopulateConductingDropDownList(_context, emptyMeeting.Conducting);
            //return null;
            return Page();
        }
    }
}