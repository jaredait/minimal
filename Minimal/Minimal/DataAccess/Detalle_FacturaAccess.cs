using Minimal.Data;
using Minimal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.DataAccess
{
    public class Detalle_FacturaAccess : IDetalle_FacturaAccess
    {
        MinimalContext _contexto { get; set; }

        public Detalle_FacturaAccess(MinimalContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<DETALLE_FACTURA> ObtenerDetallaPorFacturaId(int id)
        {
             return _contexto.DETALLE_FACTURA.Where(df => df.FAC_NUMERO == id).ToList();
        }
    }
}
