using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public interface IClienteAccess
    {
        CLIENTE obtenerClientePorId(string id);
    }
}
