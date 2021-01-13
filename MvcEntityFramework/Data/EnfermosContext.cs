using Microsoft.EntityFrameworkCore;
using MvcEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntityFramework.Data
{
    public class EnfermosContext: DbContext
    {
        public EnfermosContext(DbContextOptions<EnfermosContext> options)
            : base(options) { }
        public DbSet<Enfermo> Enfermos { get; set; }
    }
}
