using Minimal_Cliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    interface ITipo_PagoAccess
    {
        IEnumerable<TIPO_PAGO> GetListaTipoPago();
        TIPO_PAGO GetTipoPagoPorId(string id);
    }
}
