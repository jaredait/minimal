using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Minimal.Models;

namespace Minimal.Data
{
    public class MinimalContext : DbContext
    {
        public MinimalContext (DbContextOptions<MinimalContext> options)
            : base(options)
        {
        }

        public DbSet<Minimal.Models.CATEGORIA> CATEGORIA { get; set; }

        public DbSet<Minimal.Models.ENVIO> ENVIO { get; set; }

        public DbSet<Minimal.Models.TIPO_PAGO> TIPO_PAGO { get; set; }

        public DbSet<Minimal.Models.CLIENTE> CLIENTE { get; set; }

        public DbSet<Minimal.Models.PRODUCTO> PRODUCTO { get; set; }

        public DbSet<Minimal.Models.FACTURA> FACTURA { get; set; }

        public DbSet<Minimal.Models.DETALLE_FACTURA> DETALLE_FACTURA { get; set; }

        public DbSet<Minimal.Models.CATEGORIA_PRODUCTO> CATEGORIA_PRODUCTO { get; set; }

        public DbSet<Minimal.Models.PARAMETROS_GENERALES> PARAMETROS_GENERALES { get; set; }
    }
}
