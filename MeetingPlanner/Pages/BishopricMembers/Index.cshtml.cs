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

        public string PositionSort { get; set; }
        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<Bishopric> Bishopric { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            PositionSort = String.IsNullOrEmpty(sortOrder) ? "position_desc" : "";
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            CurrentFilter = searchString;

            IQueryable<Bishopric> bishopricIQ = from b in _context.Bishopric
                                                select b;

            if (!String.IsNullOrEmpty(searchString))
            {
                bishopricIQ = bishopricIQ.Where(b => b.name.Contains(searchString)
                || b.position.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    bishopricIQ = bishopricIQ.OrderByDescending(b => b.name);
                    break;
                case "position_desc":
                    bishopricIQ = bishopricIQ.OrderByDescending(b => b.position);
                    break;
                case "position":
                    bishopricIQ = bishopricIQ.OrderBy(b => b.position);
                    break;
                default:
                    bishopricIQ = bishopricIQ.OrderBy(b => b.name);
                    break;
            }

            Bishopric = await bishopricIQ.ToListAsync();
        }
    }
}
