using Minimal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.DataAccess
{
    interface IFacturaAccess
    {
        FACTURA ObtenerFacturaPorId(int id);
    }
}
