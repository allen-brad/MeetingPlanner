﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MeetingPlanner.Models
{
    public class MeetingContext : DbContext
    {
        public MeetingContext (DbContextOptions<MeetingContext> options)
            : base(options)
        {
        }

        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<MusicalNumber> MusicalNumber { get; set; }
        public DbSet<Talk> Talk { get; set; }
        public DbSet<Testimonies> Testimonies { get; set; }

    }
}
