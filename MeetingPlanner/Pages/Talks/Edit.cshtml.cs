using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;

namespace MeetingPlanner.Pages.Talks
{
    public class EditModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public EditModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["MeetingID"] = new SelectList(_context.Meeting, "MeetingID", "Conducting");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Talk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalkExists(Talk.TalkID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TalkExists(int id)
        {
            return _context.Talk.Any(e => e.TalkID == id);
        }
    }
}
