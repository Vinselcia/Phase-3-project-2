using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApplicationCrud.Models;

namespace SchoolApplicationCrud.Data
{
    public class ClassesDbContext : DbContext
    {
        public ClassesDbContext (DbContextOptions<ClassesDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolApplicationCrud.Models.Classes> Classes { get; set; } = default!;
    }
}
