using CalendarDatabase.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarDatabase
{
    public class CalendarDBContextDatabase : IdentityDbContext
    {
        public CalendarDBContextDatabase(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {

        }

        public DbSet<Calendar> Calendar { get; set; }
    }
}
