using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MeetingPlanner.Models;

namespace MeetingPlanner.Pages.Talks
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
        ViewData["MeetingID"] = new SelectList(_context.Meeting, "MeetingID", "Date");
            return Page();
        }

        [BindProperty]
        public Talk Talk { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Talk.Add(Talk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}