using Minimal.Models;
using Minimal_Cliente.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class SessionAccess
    {
        private readonly Minimal_ClienteContext _contexto;
        public CLIENTE cliente { get; set; }

        public SessionAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
            cliente = new CLIENTE();
        }

        public CLIENTE getClientePorId(string cli_usuario, string cli_contrasena)
        {
            try
            {
                CLIENTE clienteTemp;
                clienteTemp = _contexto.CLIENTE.Where(c => c.CLI_USUARIO == cli_usuario && c.CLI_CONTRASENA == cli_contrasena).FirstOrDefault();
                return clienteTemp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
