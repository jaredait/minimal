using Minimal_Cliente.Models;
using Minimal_Cliente.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class Tipo_PagoAccess : ITipo_PagoAccess
    {
        private readonly Minimal_ClienteContext _contexto;

        public Tipo_PagoAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<TIPO_PAGO> GetListaTipoPago()
        {
            return _contexto.TIPO_PAGO.ToList();
        }

        public TIPO_PAGO GetTipoPagoPorId(string id)
        {
            return _contexto.TIPO_PAGO.Where(t => t.TIP_ID == id).FirstOrDefault();
        }
    }
}
