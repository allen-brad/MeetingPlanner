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
    public class IndexModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public IndexModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public IList<Talk> Talk { get;set; }

        public async Task OnGetAsync()
        {
            Talk = await _context.Talk
                .Include(t => t.Meeting).ToListAsync();
        }
    }
}
