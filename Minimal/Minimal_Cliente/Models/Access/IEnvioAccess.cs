using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    interface IEnvioAccess
    {
        void agregarEnvio(ENVIO nuevoEnvio);
    }
}
