﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;
using Microsoft.AspNetCore.Authorization;

namespace MeetingPlanner.Pages.Meetings
{
    [Authorize]
    public class IndexModel : BishopricNamePageModel//PageModel
    {
        private readonly MeetingPlanner.Models.MeetingContext _context;

        public IndexModel(MeetingPlanner.Models.MeetingContext context)
        {
            _context = context;
        }

        public string PresidingSort { get; set; }
        public string ConductingSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<Meeting> Meeting { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            PresidingSort = String.IsNullOrEmpty(sortOrder) ? "presiding_desc" : "";
            ConductingSort = String.IsNullOrEmpty(sortOrder) ? "conducting_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            CurrentFilter = searchString;

            IQueryable<Meeting> meetingIQ = from m in _context.Meeting
                                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                meetingIQ = meetingIQ.Where(m => m.Announcements.Contains(searchString) || m.Conducting.Contains(searchString) || m.Presiding.Contains(searchString) || m.WardBusiness.Contains(searchString) || m.StakeBusiness.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "presiding_desc":
                    meetingIQ = meetingIQ.OrderByDescending(m => m.Presiding);
                    break;
                case "Presiding":
                    meetingIQ = meetingIQ.OrderBy(m => m.Presiding);
                    break;
                case "conducting_desc":
                    meetingIQ = meetingIQ.OrderByDescending(m => m.Conducting);
                    break;
                case "Conducting":
                    meetingIQ = meetingIQ.OrderBy(m => m.Conducting);
                    break;
                case "date_desc":
                    meetingIQ = meetingIQ.OrderByDescending(m => m.Date);
                    break;
                default:
                    meetingIQ = meetingIQ.OrderBy(m => m.Date);
                    break;
            }

            //Bishopric = await _context.Bishopric.FirstOrDefaultAsync(m => m.BishopricID == id);
            Meeting = await meetingIQ
                .Include(m => m.Bishopric)

                .AsNoTracking()
                .ToListAsync();
            //PopulateConductingDropDownList(_context);
            
            
        }
    }
}
