using Minimal.Data;
using Minimal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.DataAccess
{
    public class FacturaAccess : IFacturaAccess
    {
        MinimalContext _contexto { get; set; }

        public FacturaAccess(MinimalContext contexto)
        {
            _contexto = contexto;
        }

        public FACTURA ObtenerFacturaPorId(int id)
        {
            return _contexto.FACTURA.Where(f => f.FAC_NUMERO == id).FirstOrDefault();
        }
    }
}
