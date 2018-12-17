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
    public class IndexModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public IndexModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public IList<Bishopric> Bishopric { get;set; }

        public async Task OnGetAsync()
        {
            Bishopric = await _context.Bishopric.ToListAsync();
        }
    }
}
