using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public interface IFacturacionAccess
    {
        void RegistrarVenta(FACTURA factura, List<CARRITO> listaProductos);
        decimal ObtenerTotalListaCarrito(List<CARRITO> listaCarrito);
    }
}
