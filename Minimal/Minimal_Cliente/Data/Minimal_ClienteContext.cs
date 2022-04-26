using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Minimal.Models;
using Minimal_Cliente.Models;

namespace Minimal_Cliente.Data
{
    public class Minimal_ClienteContext : DbContext
    {
        public Minimal_ClienteContext (DbContextOptions<Minimal_ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<Minimal.Models.PRODUCTO> PRODUCTO { get; set; }
        public DbSet<Minimal.Models.CLIENTE> CLIENTE { get; set; }
        public DbSet<Minimal_Cliente.Models.CARRITO> CARRITO { get; set; }

    }
}
