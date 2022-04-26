using Minimal_Cliente.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class CarritoAccess : ICarritoAccess
    {
        private readonly Minimal_ClienteContext _contexto;
        public List<CARRITO> ListaCarrito { get; set; }

        public CarritoAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
            ListaCarrito = new List<CARRITO>();
        }

        public bool AddProducto(CARRITO carritoNuevo)
        {
            try
            {
                _contexto.CARRITO.Add(carritoNuevo);
                _contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
