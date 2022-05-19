using Minimal_Cliente.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class EnvioAccess : IEnvioAccess
    {
        private readonly Minimal_ClienteContext _contexto;

        public EnvioAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
        }


        public void agregarEnvio(ENVIO nuevoEnvio)
        {
            _contexto.ENVIO.Add(nuevoEnvio);
            _contexto.SaveChanges();
        }
    }
}
