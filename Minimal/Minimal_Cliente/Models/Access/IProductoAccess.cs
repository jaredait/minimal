using Minimal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public interface IProductoAccess
    {
        IEnumerable<PRODUCTO> getProductosPorId(string[] ids);

    }
}
