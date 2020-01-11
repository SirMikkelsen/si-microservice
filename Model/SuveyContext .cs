using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SuveyApp.Model
{
    public class SuveyContext : DbContext
    {
        public SuveyContext(DbContextOptions<SuveyContext> options)
             : base(options)
        {
        }

        public DbSet<SuveyItem> SuveyItems { get; set; }
    }
}
