﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MeetingPlanner.Models;
using Microsoft.AspNetCore.Authorization;

namespace MeetingPlanner.Pages.BishopricMembers
{
    [Authorize]
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
        public Bishopric Bishopric { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bishopric.Add(Bishopric);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}