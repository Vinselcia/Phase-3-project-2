using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApplicationCrud.Models;

namespace SchoolApplicationCrud.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolApplicationCrud.Models.Student> Student { get; set; } = default!;
    }
}
