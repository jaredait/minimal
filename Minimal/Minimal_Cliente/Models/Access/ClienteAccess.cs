using Minimal_Cliente.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class ClienteAccess : IClienteAccess
    {
        private readonly Minimal_ClienteContext _contexto;

        public ClienteAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
        }

        public CLIENTE obtenerClientePorId(string id)
        {
            return _contexto.CLIENTE.Where(c => c.CLI_USUARIO == id).FirstOrDefault();
        }
    }
}
