using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Familia.Models;

namespace Familia.Data
{
    public class FamiliaContext : DbContext
    {
        public FamiliaContext (DbContextOptions<FamiliaContext> options)
            : base(options)
        {
        }

        public DbSet<Familia.Models.Login> Login { get; set; } = default!;
    }
}
