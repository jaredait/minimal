using Minimal_Cliente.Models.Access;
using Minimal_Cliente.RepositorioDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.AccessLocal
{
    public class ClienteAccessLocal : IClienteAccess
    {
        public CLIENTE obtenerClientePorId(string id)
        {
            DatosCliente datosCliente = new DatosCliente();
            return datosCliente.ListaClientes.Where(cli => cli.CLI_USUARIO == id).FirstOrDefault();
        }
    }
}
