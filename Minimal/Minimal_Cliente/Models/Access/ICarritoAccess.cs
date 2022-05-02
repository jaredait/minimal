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
        List<CARRITO> getProductos(string CLI_USUARIO);
        //List<PRODUCTO> getProductosCarrito();
    }
}
