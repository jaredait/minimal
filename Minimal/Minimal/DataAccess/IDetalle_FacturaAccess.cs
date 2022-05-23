using Minimal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.DataAccess
{
    public interface IDetalle_FacturaAccess
    {
        IEnumerable<DETALLE_FACTURA> ObtenerDetallaPorFacturaId(int id);
    }
}
