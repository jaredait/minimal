using Minimal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    interface ICarritoAccess
    {
        bool AddProducto(CARRITO carritoNuevo);
        List<CARRITO> GetProductos(string CLI_USUARIO);
        CARRITO GetCarritoPorId(int id);
    }
}
