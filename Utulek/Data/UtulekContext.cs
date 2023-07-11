using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Utulek.Models;

namespace Utulek.Data
{
    public class UtulekContext : DbContext
    {
        public UtulekContext (DbContextOptions<UtulekContext> options)
            : base(options)
        {
        }

        public DbSet<Utulek.Models.Pes> Pes { get; set; } = default!;
        public DbSet<Utulek.Models.Kocka> Kocka { get; set; } = default!;
    }
}
