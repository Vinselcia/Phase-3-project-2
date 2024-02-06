using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApplicationCrud.Models;

namespace SchoolApplicationCrud.Data
{
    public class SubjectDbContext : DbContext
    {
        public SubjectDbContext (DbContextOptions<SubjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolApplicationCrud.Models.Subject> Subject { get; set; } = default!;
    }
}
