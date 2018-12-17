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
    public class DeleteModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public DeleteModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bishopric = await _context.Bishopric.FindAsync(id);

            if (Bishopric != null)
            {
                _context.Bishopric.Remove(Bishopric);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
